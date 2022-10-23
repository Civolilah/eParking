using eParking.Data;
using eParking.Data.Requests;
using eParking.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eParking.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize(Roles = "Administrator,Radnik")]
    public class KorisnikController : ControllerBase
    {
        private IKorisnikService _korisnikService;
        public KorisnikController(IKorisnikService korisnikService)
        {
            _korisnikService = korisnikService;
        }

        [HttpGet]
        [Route("[action]")]
        public List<Uloge> GetUloge()
        {
            return _korisnikService.GetUloge();
        }
        [HttpGet]
        [Route("[action]")]
        public List<Parking> GetParkinge()
        {
            return _korisnikService.GetListuParkinga();
        }
        [HttpGet]
        [Route("[action]")]
        public List<Data.Korisnik> GetSveKorisnike()
        {
            return _korisnikService.GetSveKorisnike();
        }
        [HttpGet]
        [Route("[action]/{UserName}")]
        public InsertNoviKorisnikRequest GetKorisnika(string UserName)
        {
            return _korisnikService.GetKorisnika(UserName);
        }
        [HttpPost]
        [Route("[action]")]
        public InsertNovaUlogaRequest InsertNovaUloga([FromQuery] InsertNovaUlogaRequest model)
        {
            return _korisnikService.InsertNovaUloga(model);
        }
        [HttpPost]
        [Route("[action]")]
        public InsertNoviKorisnikRequest InsertNoviKorisnik([FromQuery] InsertNoviKorisnikRequest model)
        {
            return _korisnikService.InsertNoviKorisnik(model);
        }
        [HttpPost]
        [Route("[action]")]
        public UrediKorisnikaRequest UrediKorisnika([FromQuery] UrediKorisnikaRequest model)
        {
            return _korisnikService.UrediKorisnika(model);
        }
        [HttpGet]
        [Route("[action]/{id}")]
        public UrediKorisnikaVM GetUrediKorisnika(int id)
        {
            return _korisnikService.GetUrediKorisnika(id);
        }
        [HttpGet]
        [Route("[action]/{UserName}")]
        public bool IsUnique(string UserName)
        {
            return _korisnikService.IsUnique(UserName);
        }
        [HttpDelete]
        [Route("[action]")]
        public Data.Korisnik IzbrisiKorisnika(int id)
        {
            return _korisnikService.IzbrisiKorisnika(id);
        }
    }
}
