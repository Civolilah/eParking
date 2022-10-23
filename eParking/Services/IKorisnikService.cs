using eParking.Data;
using eParking.Data.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eParking.Services
{
    public interface IKorisnikService
    {
        Korisnik Autentifikacija(string username, string password);
        List<Uloge> GetUloge();
        bool IsUnique(string UserName);
        List<Parking> GetListuParkinga();
        InsertNovaUlogaRequest InsertNovaUloga(InsertNovaUlogaRequest model);
        InsertNoviKorisnikRequest InsertNoviKorisnik(InsertNoviKorisnikRequest model);
        InsertNoviKorisnikRequest GetKorisnika(string UserName);
        List<Data.Korisnik> GetSveKorisnike();
        Data.Korisnik IzbrisiKorisnika(int id);
        UrediKorisnikaRequest UrediKorisnika(UrediKorisnikaRequest model);
        UrediKorisnikaVM GetUrediKorisnika(int id);
    }
}
