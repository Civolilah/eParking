using System;
using System.Collections.Generic;
using System.Text;

namespace eParking.Data
{
    public class PriviewSveParkinge
    {
        public int ParkingID { get; set; }
        public string NazivParkinga { get; set; }
        public string Grad { get; set; }
        public string RadnoVrijeme { get; set; }
        public int BrojParkingMijesta { get; set; }
        public string Aktivan { get; set; }
    }
}
