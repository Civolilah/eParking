using eParking.Data;
using eParking.Data.Requests;
using eParking.Database;
using Microsoft.EntityFrameworkCore;
using SmartRestaurant.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eParking.Services
{
    public class KorisnikService:IKorisnikService
    {
        private AppDBContext _context;
        public KorisnikService(AppDBContext context)
        {
            _context = context;
        }
        public Korisnik Authenticiraj(string username, string pass)
        {
            var user = _context.Korisnici.FirstOrDefault(x => x.NazivKorisnika == username);

            if (user != null)
            {
                var hashedPass = GenerateHash(user.PasswordSalt, pass);

                if (hashedPass == user.PasswordHash)
                {
                    return _context.Korisnici.Where(a=> a.NazivKorisnika==username).Select(a=> new Korisnik { 
                            KorisnikID=a.KorisnikID,
                            NazivKorisnika=a.NazivKorisnika
                    }).FirstOrDefault();
                }
            }

            return null;
        }
        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
        public Korisnik Autentifikacija(string nazivkorisnika, string password)
        {
            string nazivv = "";
            string passwordd = "";
            int brojac = 0;
            if (nazivkorisnika.StartsWith(" "))
            {
                foreach (var item in nazivkorisnika)
                {
                    if (brojac == 0)
                    {
                        brojac++;
                    }
                    else
                    {
                        nazivv += item;
                    }
                }
                brojac = 0;
                foreach (var item in password)
                {
                    if (brojac == 0)
                    {
                        brojac++;
                    }
                    else
                    {
                        passwordd += item;
                    }
                }
                nazivkorisnika = nazivv;
                password = passwordd;
            }
            var user = _context.Korisnici.Where(a => a.NazivKorisnika == nazivkorisnika).FirstOrDefault();

            if (user != null)
            {
                var hashedPass = GenerateHash(user.PasswordSalt, password);

                if (hashedPass == user.PasswordHash)
                {
                    return _context.Korisnici.Where(a => a.NazivKorisnika == nazivkorisnika).Select(a => new Korisnik
                    {
                        KorisnikID = a.KorisnikID,
                        NazivKorisnika = a.NazivKorisnika
                    }).FirstOrDefault();
                }
            }

            return null;
        }
        public List<Data.Uloge> GetUloge()
        {
            return _context.Uloge.Select(a=> new Data.Uloge { 
                UlogaID=a.UlogaID,
                Naziv=a.Naziv
            }).ToList();
        }
        public bool IsUnique(string UserName)
        {
            Korisnici korisnik = null;
            korisnik = _context.Korisnici.Where(a => a.NazivKorisnika == UserName).FirstOrDefault();
            if (korisnik == null)
            {
                return false;
            }
            return true;
        }
        public List<Parking> GetListuParkinga()
        {
            return _context.Parkinzi.Include(a=>a.Grad).Select(a => new Parking
            {
                GradID=a.GradID,
                Naziv=a.Naziv,
                Grad=new Grad
                {
                    GradID=a.GradID,
                    Naziv=a.Grad.Naziv,
                    Skracenica=a.Grad.Skracenica
                },
                ParkingID=a.ParkingID,
                RadnoVrijeme=a.RadnoVrijemeOD.Hour.ToString()+" : "+a.RadnoVrijemeOD.Minute.ToString()+" | "+a.RadnoVrijemeDO.Hour.ToString()+" : "+a.RadnoVrijemeDO.Minute.ToString(),
                XKoordinata=a.XKoordinata,
                YKoordinata=a.YKoordinata
            }).ToList();
        }
        public InsertNovaUlogaRequest InsertNovaUloga(InsertNovaUlogaRequest model)
        {
            Database.Uloge nova = new Database.Uloge
            {
                Naziv=model.NazivUloge
            };
            _context.Add(nova);
            _context.SaveChanges();
            return model;
        }
        public InsertNoviKorisnikRequest InsertNoviKorisnik(InsertNoviKorisnikRequest model)
        {
            Korisnici korisnik = null;
            korisnik=_context.Korisnici.Where(a => a.NazivKorisnika.ToLower() == model.KorisnickoIme.ToLower()).FirstOrDefault();

            if (korisnik != null)
            {
                model.KorisnickoIme = "Postoji";
                return model;
            }
            else
            {
                Korisnici novi = new Korisnici
                {
                    NazivKorisnika=model.KorisnickoIme
                };
                novi.PasswordSalt = GenerateSalt();
                novi.PasswordHash = GenerateHash(novi.PasswordSalt, model.Lozinka);

                _context.Add(novi);
                _context.SaveChanges();

                KorisnikUloga novauloga = new KorisnikUloga
                {
                    KorisnikID=novi.KorisnikID,
                    UlogaID=model.UlogaID
                };
                _context.Add(novauloga);
                _context.SaveChanges();

                if (model.UlogaID != 1)
                {
                    KorisnikParking novipar = new KorisnikParking
                    {
                        KorisnikID=novi.KorisnikID,
                        ParkingID=model.ParkingID
                    };
                    _context.Add(novipar);
                    _context.SaveChanges();
                }

                return model;
            }
        }
        public InsertNoviKorisnikRequest GetKorisnika(string UserName)
        {
            InsertNoviKorisnikRequest model = null;
            model = _context.KorisniciUloge.Include(a => a.Korisnik).Where(a => a.Korisnik.NazivKorisnika == UserName).Select(a => new InsertNoviKorisnikRequest
            {
                KorisnickoIme=UserName,
                UlogaID=a.UlogaID
            }).FirstOrDefault();

            return model;
        }
        public List<Korisnik> GetSveKorisnike()
        {
            return _context.KorisniciUloge.Include(a => a.Korisnik).Include(a => a.Uloga).Select(a => new Korisnik
            {
                KorisnikID=a.KorisnikID,
                Uloga=a.Uloga.Naziv,
                NazivKorisnika=a.Korisnik.NazivKorisnika
            }).ToList();
        }
        public Korisnik IzbrisiKorisnika(int id)
        {
            Korisnik korisnik = null;
            korisnik=_context.Korisnici.Where(a => a.KorisnikID == id).Select(a => new Data.Korisnik
            {
                KorisnikID=a.KorisnikID
            }).FirstOrDefault();

            Korisnici korisnik1 = _context.Korisnici.Where(a => a.KorisnikID == id).FirstOrDefault();
            
            if (korisnik == null)
            {
                korisnik = new Korisnik();
                korisnik.NazivKorisnika = "NePostoji";
                return korisnik;
            }

            int ulogaid = _context.KorisniciUloge.Where(a => a.KorisnikID == id).Select(a => a.UlogaID).FirstOrDefault();
            if (ulogaid != 1)
            {
                KorisnikParking kp = _context.KorisnikParking.Where(a => a.KorisnikID == id).FirstOrDefault();
                _context.Remove(kp);
                _context.SaveChanges();
            }
            KorisnikUloga ku = _context.KorisniciUloge.Where(a => a.KorisnikID == id).FirstOrDefault();
            _context.Remove(ku);
            _context.SaveChanges();

            _context.Remove(korisnik1);
            _context.SaveChanges();
            return korisnik;
        }
        public UrediKorisnikaRequest UrediKorisnika(UrediKorisnikaRequest model)
        {
            Korisnici korisnik = null;
            korisnik=_context.Korisnici.Where(a => a.KorisnikID == model.KorisnikID).FirstOrDefault();

            string hash = GenerateHash(korisnik.PasswordSalt, model.StariPassword);
            if (korisnik.PasswordHash != hash)
            {
                model.StariPassword = "Stari";
                return model;
            }

            korisnik.NazivKorisnika = model.KorisnickoIme;
            _context.SaveChanges();
            if (!string.IsNullOrEmpty(model.NoviPassoword))
            {
                string novisalt = GenerateSalt();
                korisnik.PasswordSalt = novisalt;
                korisnik.PasswordHash = GenerateHash(novisalt, model.NoviPassoword);
                _context.SaveChanges();
            }

            KorisnikUloga ku = _context.KorisniciUloge.Where(a => a.KorisnikID == model.KorisnikID).FirstOrDefault();
            if (ku.UlogaID == model.UlogaID && model.UlogaID != 1)
            {
                KorisnikParking kp = _context.KorisnikParking.Where(a => a.KorisnikID == model.KorisnikID).FirstOrDefault();
                kp.ParkingID = model.ParkingID;
                _context.SaveChanges();
            }
            if (ku.UlogaID != model.UlogaID)
            {
                if (ku.UlogaID == 1)
                {
                    KorisnikParking kp = new KorisnikParking
                    {
                        KorisnikID=ku.KorisnikID,
                        ParkingID=model.ParkingID
                    };
                    _context.Add(kp);
                    _context.SaveChanges();
                }
                if (model.UlogaID == 1)
                {
                    KorisnikParking kp = _context.KorisnikParking.Where(a => a.KorisnikID == model.KorisnikID).FirstOrDefault();
                    _context.Remove(kp);
                    _context.SaveChanges();
                }
                ku.UlogaID = model.UlogaID;
                _context.SaveChanges();

            }
            return model;
        }
        public UrediKorisnikaVM GetUrediKorisnika(int id)
        {
            Korisnici korisnik = null;
            korisnik=_context.Korisnici.Where(a => a.KorisnikID == id).FirstOrDefault();
            if (korisnik == null)
            {
                UrediKorisnikaVM model1 = new UrediKorisnikaVM
                {
                    KorisnickoIme = "NePostoji"
                };
                return model1;
            }
            UrediKorisnikaVM model = new UrediKorisnikaVM
            {
                KorisnickoIme = korisnik.NazivKorisnika
            };
            model.UlogaID = _context.KorisniciUloge.Where(a => a.KorisnikID == id).Select(a => a.UlogaID).FirstOrDefault();
            if (model.UlogaID != 1)
            {
                model.ParkingID = _context.KorisnikParking.Where(a => a.KorisnikID == id).Select(a => a.ParkingID).FirstOrDefault();
            }
            return model;
        }
    }
}
