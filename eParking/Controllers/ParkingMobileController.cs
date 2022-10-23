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
    [AllowAnonymous]
    public class ParkingMobileController : ControllerBase
    {
        private IParkingService _parkingService;
        public ParkingMobileController(IParkingService parkingService)
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
        public List<IspisParkingaRequest> GetParkingeByGrad([FromQuery] ListaParkingaRequest model)
        {
            return _parkingService.GetParkingeByGrad(model);
        }

        [HttpGet]
        [Route("[action]")]
        public List<IspisParkingaRequest> GetParkingPreporuku([FromQuery] ListaParkingaRequest model)
        {
            return _parkingService.GetParkingPreporuku(model);
        }
        [HttpGet]
        [Route("[action]")]
        public List<ParkingDetaljiRequest> GetParking([FromQuery] ParkingDetaljiVM model)
        {
            return _parkingService.GetParkingDetalji(model);
        }
        [HttpGet]
        [Route("[action]")]
        public GetSveLokacijeParkingaRequest GetSveLokacijeParkinga()
        {
            return _parkingService.GetSveLokacijeParkinga();
        }
    }
}
