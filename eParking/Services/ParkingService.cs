using eParking.Data;
using eParking.Data.Requests;
using eParking.Data.ViewModels;
using eParking.Database;
using Microsoft.EntityFrameworkCore;
using SmartRestaurant.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eParking.Services
{
    public class ParkingService : IParkingService
    {
        private AppDBContext _context;
        public ParkingService(AppDBContext context)
        {
            _context = context;
        }
        public List<Drzava> GetDrzave()
        {
            return _context.Drzave.Select(a => new Drzava
            {
                DrzavaID=a.DrzavaID,
                Naziv=a.Naziv,
                Skracenica=a.Skracenica
            }).ToList();
        }
        public List<Grad> GetSveGradove()
        {
            return _context.Gradovi.Select(a => new Grad
            {
                GradID=a.GradID,
                Naziv=a.Naziv,
                Skracenica=a.Skracenica
            }).ToList();
        }
        public List<PriviewSveParkinge> GetSveParkinge()
        {
            return _context.Parkinzi.Include(a => a.Grad).Select(a => new PriviewSveParkinge
            {
                ParkingID=a.ParkingID,
                Grad=a.Grad.Naziv,
                RadnoVrijeme=GetRadnoVrijeme(a.RadnoVrijemeOD,a.RadnoVrijemeDO),
                BrojParkingMijesta=_context.ParkingParkingMjesta.Where(b=> b.ParkingID==a.ParkingID).Count(),
                NazivParkinga=a.Naziv,
                Aktivan=AktiveToString(a.Aktivan)
            }).ToList();
        }
        private static string GetRadnoVrijeme(DateTime OD, DateTime DO)
        {
            string final = "";
            if (OD.Hour < 10)
            {
                final += "0" + OD.Hour.ToString();
            }
            else
            {
                final += OD.Hour.ToString();
            }
            final += " : ";
            if (OD.Minute < 10)
            {
                final += "0" + OD.Minute.ToString();
            }
            else
            {
                final += OD.Minute.ToString();
            }
            final += "h - ";
            if (DO.Hour < 10)
            {
                final += "0" + DO.Hour.ToString();
            }
            else
            {
                final += DO.Hour.ToString();
            }
            final += " : ";
            if (DO.Minute < 10)
            {
                final += "0" + DO.Minute.ToString();
            }
            else
            {
                final += DO.Minute.ToString();
            }
            final += "h";
            return final;
        }
        private static string AktiveToString(bool akt)
        {
            if (akt == false)
                return "Neaktivan";
            return "Aktivan";
        }
        public List<TipParkingMjesta> GetTipoveParkingMjesta()
        {
            return _context.TipParkingMijesta.Select(a => new TipParkingMjesta
            {
                Naziv=a.Naziv,
                TipParkingMjestaID =a.TipParkingMjestaID
            }).ToList();
        }
        public InsertDrzavaRequest InsertDrzavu(InsertDrzavaRequest model)
        {
            Drzave nova = new Drzave { 
                Naziv=model.NazivDrzave,
                Skracenica=model.Skracenica
            };
            _context.Add(nova);
            _context.SaveChanges();

            return model;
        }
        public InsertGradRequest InsertGrad(InsertGradRequest model)
        {
            Gradovi novi = new Gradovi
            {
                DrzavaID=model.DrzavaID,
                Naziv=model.NazivGrada,
                Skracenica=model.Skracenica
            };
            _context.Add(novi);
            _context.SaveChanges();
            return model;
        }
        public InsertNovoParkingMjesto InsertNovoParkingMjesto(InsertNovoParkingMjesto model)
        {
            InsertNovoParkingMjesto check = null;
            check = _context.ParkingParkingMjesta.Include(a=>a.Parking).Include(a=>a.ParkingMjesto).Where(a => a.ParkingID == model.ParkingID && a.ParkingMjesto.Naziv.ToLower() == model.NazivParkingMjesta.ToLower()).Select(a=> new InsertNovoParkingMjesto { 
                ParkingID=a.ParkingID
            }).FirstOrDefault();
            if (check != null)
            {
                check.NazivParkingMjesta = "Postoji";
                return check;
            }
            else
            {
                ParkingMjesta novomjesto = new ParkingMjesta
                {
                    Naziv=model.NazivParkingMjesta
                };
                _context.Add(novomjesto);
                _context.SaveChanges();
                TipParkingMjestaParkingMjesto novitip = new TipParkingMjestaParkingMjesto
                {
                    ParkingMjestoID= novomjesto.ParkingMjestoID,
                    TipParkingMjestaID=model.TipMjestaID
                };
                _context.Add(novitip);
                _context.SaveChanges();

                ParkingParkingMjesto novomjestos = new ParkingParkingMjesto
                {
                    ParkingID=model.ParkingID,
                    ParkingMjestoID=novomjesto.ParkingMjestoID
                };

                _context.Add(novomjestos);
                _context.SaveChanges();

                return model;
            }
        }
        public NoviParkingRequest InsertParking(NoviParkingRequest model)
        {
            Parkinzi novi = new Parkinzi
            {
                GradID=model.GradID,
                Naziv=model.NazivParkinga,
                RadnoVrijemeOD=new DateTime(model.RadnoVrijemeOD.Year, model.RadnoVrijemeOD.Month, model.RadnoVrijemeOD.Day, model.RadnoVrijemeOD.Hour-2, model.RadnoVrijemeOD.Minute,0),
                RadnoVrijemeDO= new DateTime(model.RadnoVrijemeDO.Year, model.RadnoVrijemeDO.Month, model.RadnoVrijemeDO.Day, model.RadnoVrijemeDO.Hour-2, model.RadnoVrijemeDO.Minute, 0),
                XKoordinata=model.Lat,
                YKoordinata=model.Lng,
                Aktivan=model.Aktivan
            };
            _context.Add(novi);
            _context.SaveChanges();
            return model;
        }
        public InsertTipParkingMjestaResponse InsertTipParkingMjesta(string NazivTipa)
        {
            TipParkingMijesta novo = new TipParkingMijesta();
            novo.Naziv = NazivTipa;
            TipParkingMijesta provjera = null;
            InsertTipParkingMjestaResponse rett = new InsertTipParkingMjestaResponse();
            provjera = _context.TipParkingMijesta.Where(a => a.Naziv.ToLower() == NazivTipa.ToLower()).FirstOrDefault();
            if (provjera != null)
            {
                rett.Response = "Postoji";
                return rett;
            }
            else
            {
                rett.Response = NazivTipa;
                _context.Add(novo);
                _context.SaveChanges();
                return rett;
            }
        }
        public DeleteParkingRequest IzbrisiParking(int id)
        {
            DeleteParkingRequest rett = new DeleteParkingRequest
            {
                ParkingID=id
            };
            Parkinzi model = null;
            model=_context.Parkinzi.Where(a => a.ParkingID == id).FirstOrDefault();
            if (model != null)
            {
                List<ParkingParkingMjesto> parkingmjesta = _context.ParkingParkingMjesta.Where(a => a.ParkingID == id).ToList();
                List<int> listaideva= _context.ParkingParkingMjesta.Where(a => a.ParkingID == id).Select(a=>a.ParkingMjestoID).ToList();
                List<TipParkingMjestaParkingMjesto> listatipova = _context.TipParkingMjestaParkingMjesta.ToList();
                List<TipParkingMjestaParkingMjesto> finallistatipova = new List<TipParkingMjestaParkingMjesto>();
                foreach (var item in listatipova)
                {
                    if (IsTrue(item.ParkingMjestoID, listaideva))
                    {
                        finallistatipova.Add(item);
                    }
                }
                foreach (var item in finallistatipova)
                {
                    _context.Remove(item);
                    _context.SaveChanges();
                }
                foreach (var item in parkingmjesta)
                {
                    _context.Remove(item);
                    _context.SaveChanges();
                }
                _context.Remove(model);
                _context.SaveChanges();
                rett.NazivParkinga = "Ok";
            }
            else
            {
                rett.NazivParkinga = "NePostoji";
            }

            return rett;
        }
        private bool IsTrue(int id, List<int> lista)
        {
            foreach (var item in lista)
            {
                if (id == item)
                    return true;
            }
            return false;
        }
        public UrediParkingRequest UrediParking(int id)
        {
            Parkinzi parking = null;
            parking= _context.Parkinzi.Where(a => a.ParkingID == id).FirstOrDefault();
            if (parking == null)
            {
                UrediParkingRequest modret = new UrediParkingRequest
                {
                    NazivParkinga = "NePostoji!"
                };
                return modret;
            }
            UrediParkingRequest model = new UrediParkingRequest
            {
                NazivParkinga=parking.Naziv,
                Aktivan=parking.Aktivan,
                Lat=parking.XKoordinata,
                Lang=parking.YKoordinata,
                RadnoVrijemeOD= new DateTime(parking.RadnoVrijemeOD.Year, parking.RadnoVrijemeOD.Month, parking.RadnoVrijemeOD.Day, parking.RadnoVrijemeOD.Hour, parking.RadnoVrijemeOD.Minute, 0),
                RadnoVrijemeDO = new DateTime(parking.RadnoVrijemeDO.Year, parking.RadnoVrijemeDO.Month, parking.RadnoVrijemeDO.Day, parking.RadnoVrijemeDO.Hour, parking.RadnoVrijemeDO.Minute, 0)
            };

            List<ListaParkingMijestaRequest> templist= _context.TipParkingMjestaParkingMjesta.Include(a => a.ParkingMjesto).Include(a => a.Tip).Select(a => new ListaParkingMijestaRequest
            {
                NazivParkingMjesta=a.ParkingMjesto.Naziv,
                NazivTipaParkingMjesta=a.Tip.Naziv,
                ParkingMjestoID=a.ParkingMjestoID
            }).ToList();
            List<ListaParkingMijestaRequest> finallist = new List<ListaParkingMijestaRequest>();
            foreach (var item in templist)
            {
                ParkingParkingMjesto temp = null;
                temp = _context.ParkingParkingMjesta.Where(a => a.ParkingID == id && a.ParkingMjestoID == item.ParkingMjestoID).FirstOrDefault();

                if (temp != null)
                {
                    finallist.Add(item);
                }
            }
            model.ListaParkingMijesta = finallist;

            return model;
        }
        public NoviParkingRequest IzmijeniParking(NoviParkingRequest model)
        {
            Parkinzi current = _context.Parkinzi.Where(a => a.ParkingID == model.ParkingID).FirstOrDefault();
            current.GradID = model.GradID;
            current.Naziv = model.NazivParkinga;
            current.RadnoVrijemeOD = new DateTime(model.RadnoVrijemeOD.Year, model.RadnoVrijemeOD.Month, model.RadnoVrijemeOD.Day, model.RadnoVrijemeOD.Hour-1, model.RadnoVrijemeOD.Minute, 0);
            current.RadnoVrijemeDO = new DateTime(model.RadnoVrijemeDO.Year, model.RadnoVrijemeDO.Month, model.RadnoVrijemeDO.Day, model.RadnoVrijemeDO.Hour-1, model.RadnoVrijemeDO.Minute, 0);
            current.XKoordinata = model.Lat;
            current.YKoordinata = model.Lng;
            current.Aktivan = model.Aktivan;
            _context.SaveChanges();
            return model;
        }
        public InsertNovoParkingMjesto UrediParkingMjesto(InsertNovoParkingMjesto model)
        {
            ParkingMjesta obj = null;
            obj = _context.ParkingMjesta.Where(a => a.ParkingMjestoID == model.ParkingID).FirstOrDefault();
            if (obj == null)
            {
                model.NazivParkingMjesta = "NePostoji";
                return model;
            }
            TipParkingMjestaParkingMjesto objj = _context.TipParkingMjestaParkingMjesta.Where(a => a.ParkingMjestoID == model.ParkingID).FirstOrDefault();
            obj.Naziv = model.NazivParkingMjesta;
            objj.TipParkingMjestaID = model.TipMjestaID;
            _context.SaveChanges();
            return model;
        }
        public UrediParkingMjestoRequest GetUrediParkingMjesto(int id)
        {
            ParkingMjesta obj = null;
            obj=_context.ParkingMjesta.Where(a => a.ParkingMjestoID == id).FirstOrDefault();
            if (obj != null)
            {
                UrediParkingMjestoRequest model = new UrediParkingMjestoRequest
                {
                    NazivParkingMjesta=obj.Naziv
                };
                return model;
            }
            else
            {
                UrediParkingMjestoRequest model = new UrediParkingMjestoRequest
                {
                    NazivParkingMjesta = "NePostoji"
                };
                return model;
            }
        }
        public DeleteParkingMjestoRequest IzbrisiParkingMjesto(int id)
        {
            DeleteParkingMjestoRequest m = new DeleteParkingMjestoRequest
            {
                Naziv="Model"
            };
            ParkingMjesta mjesto = null;
            mjesto = _context.ParkingMjesta.Where(a => a.ParkingMjestoID == id).FirstOrDefault();

            if (mjesto == null)
            {
                m.Naziv = "NePostoji";
                return m;
            }
            TipParkingMjestaParkingMjesto tip = _context.TipParkingMjestaParkingMjesta.Where(a => a.ParkingMjestoID == id).FirstOrDefault();
            _context.Remove(tip);
            ParkingParkingMjesto prp = _context.ParkingParkingMjesta.Where(a => a.ParkingMjestoID == id).FirstOrDefault();
            _context.Remove(prp);
            _context.Remove(mjesto);
            _context.SaveChanges();
            return m;
        }
        public RadnikMainRequest GetParking(string UserName)
        {
            int parkingid = _context.KorisnikParking.Include(a => a.Korisnik).Where(a => a.Korisnik.NazivKorisnika == UserName).Select(a => a.ParkingID).FirstOrDefault();
            string nazivparkinga = _context.ParkingParkingMjesta.Include(a=>a.Parking).Where(a => a.ParkingID == parkingid).Select(a=> a.Parking.Naziv).FirstOrDefault();

            RadnikMainRequest model = new RadnikMainRequest
            {
                NazivParkinga="Parking: "+nazivparkinga
            };

            List<TipParkingMjestaParkingMjesto> listatipova = _context.TipParkingMjestaParkingMjesta.Include(a => a.Tip).ToList();

            model.ListaParkingMijesta = _context.ParkingParkingMjesta.Include(a=>a.ParkingMjesto).Where(a => a.ParkingID == parkingid).Select(a => new RadnikListaParkingMjestaRequest
            {
                ParkingMjestoID=a.ParkingMjestoID,
                Naziv=a.ParkingMjesto.Naziv,
                Status= ZauzetoSlobodno(a.ParkingMjesto.Status),
                Tip= GetTip(listatipova,a.ParkingMjestoID)
            }).ToList();

            return model;
        }
        private static string ZauzetoSlobodno(bool op)
        {
            if (op == false)
                return "Slobodno";
            return "Zauzeto";
        }
        private static string GetTip(List<TipParkingMjestaParkingMjesto> lista, int parkingmjestoid)
        {
            return lista.Where(a => a.ParkingMjestoID == parkingmjestoid).Select(a => a.Tip.Naziv).FirstOrDefault();
        }
        public ParkingMjestoStatusRequest PromjenaSlobodnoMjesto(ParkingMjestoStatusRequest model)
        {
            ParkingMjesta mode = _context.ParkingMjesta.Where(a => a.ParkingMjestoID == model.ParkingMjestoID).FirstOrDefault();
            mode.Status = false;
            _context.SaveChanges();
            return model;
        }
        public ParkingMjestoStatusRequest PromjenaZauzetoMjesto(ParkingMjestoStatusRequest model)
        {
            ParkingMjesta mode = _context.ParkingMjesta.Where(a => a.ParkingMjestoID == model.ParkingMjestoID).FirstOrDefault();
            mode.Status = true;
            _context.SaveChanges();
            return model;
        }
        public List<IspisParkingaRequest> GetParkingeByGrad(ListaParkingaRequest model)
        {
            List<ParkingParkingMjesto> listaparkinga = _context.ParkingParkingMjesta.Include(a => a.Parking).Include(a => a.ParkingMjesto).Where(a=>a.Parking.GradID==model.GradID && a.Parking.Aktivan==true).ToList();
            List<Parkinzi> listaparkinga1 = _context.Parkinzi.Where(a=>a.GradID==model.GradID && a.Aktivan==true).ToList();
            List<IspisParkingaRequest> finallist = listaparkinga1.Select(a => new IspisParkingaRequest
            {
                ParkingID=a.ParkingID,
                RadnoVrijeme=GetRadnoVrijeme(a.RadnoVrijemeOD,a.RadnoVrijemeDO),
                XKoordinata=double.Parse(a.XKoordinata),
                YKoordinata=double.Parse(a.YKoordinata),
                BrojSlobodnihMijesta=GetBrojSlobodnihMijesta(listaparkinga,a.ParkingID),
                BrojZauzetihMijesta=GetUkupanBrojMijesta(listaparkinga, a.ParkingID),
                Naziv=a.Naziv,
                TrenutnaUdaljenostOdParkinga=GetUdaljenost(a.XKoordinata,a.YKoordinata,model.Lang,model.Lat)
            }).ToList();
            return finallist;
        }
        private static double GetUdaljenost(string Y, string X,double Long, double Lat)
        {
            double udaljenost = 0;
            double langg = double.Parse(X);
            double langg1 = Long;
            double lattt = double.Parse(Y);
            double lattt1 = Lat;
            var R = 3958.8; // Radius of the Earth in miles
            var rlat1 = lattt * (Math.PI / 180); // Convert degrees to radians
            var rlat2 = lattt1 * (Math.PI / 180); // Convert degrees to radians
            var difflat = rlat2 - rlat1; // Radian difference (latitudes)
            var difflon = (langg1 - langg) * (Math.PI / 180); // Radian difference (longitudes)

            var d = 2 * R * Math.Asin(Math.Sqrt(Math.Sin(difflat / 2) * Math.Sin(difflat / 2) + Math.Cos(rlat1) * Math.Cos(rlat2) * Math.Sin(difflon / 2) * Math.Sin(difflon / 2)));
            udaljenost = d * 1.609344;
            double ret = Math.Round(udaljenost,2);
            return ret;
        }
        private static int GetBrojSlobodnihMijesta(List<ParkingParkingMjesto> lista, int parkingid)
        {
            int brojmijesta = 0;
            foreach (var item in lista)
            {
                if (item.ParkingMjesto.Status == false && item.ParkingID==parkingid)
                {
                    brojmijesta++;
                }
            }
            return brojmijesta;
        }
        private static int GetUkupanBrojMijesta(List<ParkingParkingMjesto> lista, int parkingid)
        {
            int brojmijesta = 0;
            foreach (var item in lista)
            {
                if (item.ParkingID == parkingid)
                {
                    brojmijesta++;
                }
            }
            return brojmijesta;
        }
        public List<IspisParkingaRequest> GetParkingPreporuku(ListaParkingaRequest model)
        {
            List<ParkingParkingMjesto> listaparkinga = _context.ParkingParkingMjesta.Include(a => a.Parking).Include(a => a.ParkingMjesto).Where(a => a.Parking.GradID == model.GradID && a.Parking.Aktivan == true).ToList();
            List<Parkinzi> listaparkinga1 = _context.Parkinzi.Where(a => a.GradID == model.GradID && a.Aktivan == true).ToList();
            List<IspisParkingaRequest> finallist = listaparkinga1.Select(a => new IspisParkingaRequest
            {
                ParkingID = a.ParkingID,
                RadnoVrijeme = GetRadnoVrijeme(a.RadnoVrijemeOD, a.RadnoVrijemeDO),
                XKoordinata = double.Parse(a.XKoordinata),
                YKoordinata = double.Parse(a.YKoordinata),
                BrojSlobodnihMijesta = GetBrojSlobodnihMijesta(listaparkinga, a.ParkingID),
                BrojZauzetihMijesta = GetUkupanBrojMijesta(listaparkinga, a.ParkingID),
                Naziv = a.Naziv,
                TrenutnaUdaljenostOdParkinga = GetUdaljenost(a.XKoordinata, a.YKoordinata, model.Lang, model.Lat)
            }).ToList();

            finallist = finallist.OrderByDescending(a=> a.TrenutnaUdaljenostOdParkinga).Select(a=> new IspisParkingaRequest {
                ParkingID = a.ParkingID,
                RadnoVrijeme = a.RadnoVrijeme,
                XKoordinata = a.XKoordinata,
                YKoordinata = a.YKoordinata,
                BrojSlobodnihMijesta = a.BrojSlobodnihMijesta,
                BrojZauzetihMijesta = a.BrojZauzetihMijesta,
                Naziv = a.Naziv,
                TrenutnaUdaljenostOdParkinga = a.TrenutnaUdaljenostOdParkinga
            }).ToList();

            IspisParkingaRequest preporukaparking = null;

            List<IspisParkingaRequest> finallist1 = new List<IspisParkingaRequest>();

            for (int i = finallist.Count-1; i >= 0; i--)
            {
                if (finallist[i].BrojSlobodnihMijesta > 3 && preporukaparking!=null)
                {
                    preporukaparking = finallist[i];
                }
            }

            finallist1.Add(preporukaparking);
            return finallist1;
        }
        public List<ParkingDetaljiRequest> GetParkingDetalji(ParkingDetaljiVM model)
        {
            List<ParkingParkingMjesto> listaparkinga = _context.ParkingParkingMjesta.Include(a => a.Parking).Include(a => a.ParkingMjesto).Where(a => a.Parking.ParkingID==model.ParkingID).ToList();
            List<TipParkingMjestaParkingMjesto> listatipova = _context.TipParkingMjestaParkingMjesta.Include(a => a.ParkingMjesto).Include(a => a.Tip).ToList();
            List<Parkinzi> listaparkinga1 = _context.Parkinzi.Where(a => a.ParkingID== model.ParkingID).ToList();
            List<ParkingDetaljiRequest> returnn = listaparkinga1.Select(a => new ParkingDetaljiRequest
            {
                ParkingID = a.ParkingID,
                RadnoVrijeme = GetRadnoVrijeme(a.RadnoVrijemeOD, a.RadnoVrijemeDO),
                XTacka = double.Parse(a.XKoordinata),
                YTacka = double.Parse(a.YKoordinata),
                BrojRezervisanihMijesta=GetBrojRezervisanih(listaparkinga, listatipova),
                BrojSpecijalnihMijesta= GetBrojSpecijalnih(listaparkinga, listatipova),
                UkupanBrojMijesta = GetUkupanBrojMijesta(listaparkinga, a.ParkingID),
                NazivParkinga = a.Naziv,
                TrenutnaUdaljenostOdParkinga = GetUdaljenost(a.XKoordinata, a.YKoordinata, model.Long, model.Lat),
                BrojObicnihMijesta= GetBrojObicnih(listaparkinga, listatipova)
            }).ToList();
            foreach (var item in returnn)
            {
                item.Locations = new System.Collections.ObjectModel.ObservableCollection<Data.ViewModels.Location>();
                Location oo = new Location
                {
                    Position=new Xamarin.Forms.Maps.Position(item.XTacka,item.YTacka),
                    Description="eParking",
                    Address="Bosnia and Herzegovina"
                };
                item.Locations.Add(oo);
            }
            return returnn;
        }
        private static string GetNazivTipa(List<TipParkingMjestaParkingMjesto> listatipova, int ParkingMjestoID)
        {
            string NazivTipa = null;
            foreach (var item in listatipova)
            {
                if (item.ParkingMjestoID == ParkingMjestoID)
                {
                    NazivTipa = item.Tip.Naziv;
                }
            }
            return NazivTipa;
        }
        private static int GetBrojRezervisanih(List<ParkingParkingMjesto> listparkingmijesta, List<TipParkingMjestaParkingMjesto> listatipova)
        {
            int broj = 0;
            foreach (var item in listparkingmijesta)
            {
                if (GetNazivTipa(listatipova, item.ParkingMjestoID) == "Rezervisano")
                {
                    broj++;
                }
            }

            return broj;
        }
        private static int GetBrojSpecijalnih(List<ParkingParkingMjesto> listparkingmijesta, List<TipParkingMjestaParkingMjesto> listatipova)
        {
            int broj = 0;
            foreach (var item in listparkingmijesta)
            {
                if (GetNazivTipa(listatipova, item.ParkingMjestoID) == "Osobe sa invaliditetom")
                {
                    broj++;
                }
            }

            return broj;
        }
        private static int GetBrojObicnih(List<ParkingParkingMjesto> listparkingmijesta, List<TipParkingMjestaParkingMjesto> listatipova)
        {
            int broj = 0;
            foreach (var item in listparkingmijesta)
            {
                if (GetNazivTipa(listatipova, item.ParkingMjestoID) == "Obično")
                {
                    broj++;
                }
            }

            return broj;
        }
        public GetSveLokacijeParkingaRequest GetSveLokacijeParkinga()
        {
            GetSveLokacijeParkingaRequest model = new GetSveLokacijeParkingaRequest();

            model.Locations = new System.Collections.ObjectModel.ObservableCollection<Location>();

            var listaparkinga = _context.Parkinzi.ToList();
            foreach (var item in listaparkinga)
            {
                Location oo = new Location
                {
                    Position = new Xamarin.Forms.Maps.Position(double.Parse(item.XKoordinata), double.Parse(item.YKoordinata)),
                    Description = "eParking",
                    Address = "Bosnia and Herzegovina"
                };
                model.Locations.Add(oo);
            }

            return model;
        }
    }
}
