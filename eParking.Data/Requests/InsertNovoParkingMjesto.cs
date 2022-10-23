using System;
using System.Collections.Generic;
using System.Text;

namespace eParking.Data.Requests
{
    public class InsertNovoParkingMjesto
    {
        public int ParkingID { get; set; }
        public string NazivParkingMjesta { get; set; }
        public int TipMjestaID { get; set; }
    }
}
