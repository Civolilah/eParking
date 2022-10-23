using System;
using System.Collections.Generic;
using System.Text;

namespace eParking.Data.Requests
{
    public class ListaParkingMijestaRequest
    {
        public int ParkingMjestoID { get; set; }
        public string NazivParkingMjesta { get; set; }
        public string NazivTipaParkingMjesta { get; set; }
    }
}
