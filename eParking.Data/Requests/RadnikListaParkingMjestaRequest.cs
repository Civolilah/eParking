using System;
using System.Collections.Generic;
using System.Text;

namespace eParking.Data.Requests
{
    public class RadnikListaParkingMjestaRequest
    {
        public int ParkingMjestoID { get; set; }
        public string Naziv { get; set; }
        public string Tip { get; set; }
        public string Status { get; set; }
    }
}
