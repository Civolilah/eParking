using eParking.Data;
using eParking.Data.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eParking.Services
{
    public interface IParkingService
    {
        List<Grad> GetSveGradove();
        InsertDrzavaRequest InsertDrzavu(InsertDrzavaRequest model);
        InsertGradRequest InsertGrad(InsertGradRequest model);
        NoviParkingRequest InsertParking(NoviParkingRequest model);
        NoviParkingRequest IzmijeniParking(NoviParkingRequest model);
        List<Drzava> GetDrzave();
        List<PriviewSveParkinge> GetSveParkinge();
        InsertTipParkingMjestaResponse InsertTipParkingMjesta(string NazivTipa);
        List<Data.TipParkingMjesta> GetTipoveParkingMjesta();
        InsertNovoParkingMjesto InsertNovoParkingMjesto(InsertNovoParkingMjesto model);
        InsertNovoParkingMjesto UrediParkingMjesto(InsertNovoParkingMjesto model);
        DeleteParkingRequest IzbrisiParking(int id);
        UrediParkingRequest UrediParking(int id);
        UrediParkingMjestoRequest GetUrediParkingMjesto(int id);
        DeleteParkingMjestoRequest IzbrisiParkingMjesto(int id);
        RadnikMainRequest GetParking(string UserName);
        ParkingMjestoStatusRequest PromjenaSlobodnoMjesto(ParkingMjestoStatusRequest model);
        ParkingMjestoStatusRequest PromjenaZauzetoMjesto(ParkingMjestoStatusRequest model);
        List<IspisParkingaRequest> GetParkingeByGrad(ListaParkingaRequest model);
        List<IspisParkingaRequest> GetParkingPreporuku(ListaParkingaRequest model);
        List<ParkingDetaljiRequest> GetParkingDetalji(ParkingDetaljiVM model);
        GetSveLokacijeParkingaRequest GetSveLokacijeParkinga();
    }
}
