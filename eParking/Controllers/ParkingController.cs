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
    public class ParkingController : ControllerBase
    {
        private IParkingService _parkingService;
        public ParkingController(IParkingService parkingService)
        {
            _parkingService = parkingService;
        }
        [HttpGet]
        [Route("[action]")]
        public List<Grad> GetGradove()
        {
            return _parkingService.GetSveGradove();
        }
        
        [HttpGet]
        [Route("[action]")]
        public List<PriviewSveParkinge> GetParkinge()
        {
            return _parkingService.GetSveParkinge();
        }
        [HttpGet]
        [Route("[action]/{UserName}")]
        public RadnikMainRequest GetParking(string UserName)
        {
            return _parkingService.GetParking(UserName);
        }
        [HttpGet]
        [Route("[action]/{id}")]
        public UrediParkingRequest UrediParking(int id)
        {
            return _parkingService.UrediParking(id);
        }
        [HttpGet]
        [Route("[action]/{id}")]
        public UrediParkingMjestoRequest GetUrediParkingMjesto(int id)
        {
            return _parkingService.GetUrediParkingMjesto(id);
        }
        [HttpGet]
        [Route("[action]")]
        public List<Drzava> GetDrzave()
        {
            return _parkingService.GetDrzave();
        }
        [HttpPost]
        [Route("[action]")]
        public InsertDrzavaRequest InsertDrzava([FromQuery]InsertDrzavaRequest objec)
        {
            InsertDrzavaRequest vrati= _parkingService.InsertDrzavu(objec);
            return vrati;
        }
        [HttpPost]
        [Route("[action]")]
        public InsertNovoParkingMjesto InsertParkingMjesto([FromQuery] InsertNovoParkingMjesto objec)
        {
            return _parkingService.InsertNovoParkingMjesto(objec);
        }
        [HttpPost]
        [Route("[action]")]
        public ParkingMjestoStatusRequest PromjenaSlobodnoMjesto([FromQuery] ParkingMjestoStatusRequest objec)
        {
            return _parkingService.PromjenaSlobodnoMjesto(objec);
        }
        [HttpPost]
        [Route("[action]")]
        public ParkingMjestoStatusRequest PromjenaZauzetoMjesto([FromQuery] ParkingMjestoStatusRequest objec)
        {
            return _parkingService.PromjenaZauzetoMjesto(objec);
        }
        [HttpPost]
        [Route("[action]")]
        public InsertNovoParkingMjesto UrediParkingMjesto([FromQuery] InsertNovoParkingMjesto objec)
        {
            return _parkingService.UrediParkingMjesto(objec);
        }
        [HttpPost]
        [Route("[action]")]
        public InsertGradRequest InsertGrad([FromQuery]InsertGradRequest objec)
        {
            return _parkingService.InsertGrad(objec);
        }
        [HttpPost]
        [Route("[action]")]
        public NoviParkingRequest InsertParking([FromQuery] NoviParkingRequest objec)
        {
            return _parkingService.InsertParking(objec);
        }
        [HttpPost]
        [Route("[action]")]
        public NoviParkingRequest IzmijeniParking([FromQuery] NoviParkingRequest objec)
        {
            return _parkingService.IzmijeniParking(objec);
        }
        [HttpPost]
        [Route("[action]/{naziv}")]
        public InsertTipParkingMjestaResponse InsertTipParkingMjesta(string naziv)
        {
            return _parkingService.InsertTipParkingMjesta(naziv);
        }
        [HttpGet]
        [Route("[action]")]
        public List<TipParkingMjesta> GetTipoveParkingMjesta()
        {
            return _parkingService.GetTipoveParkingMjesta();
        }
        [HttpDelete]
        [Route("[action]")]
        public DeleteParkingRequest IzbrisiParking(int id)
        {
            return _parkingService.IzbrisiParking(id);
        }

        [HttpDelete]
        [Route("[action]")]
        public DeleteParkingMjestoRequest IzbrisiParkingMjesto(int id)
        {
            return _parkingService.IzbrisiParkingMjesto(id);
        }
    }
}
