using System;
using System.Collections.Generic;
using System.Text;

namespace eParking.Data.Requests
{
    public class InsertNoviKorisnikRequest
    {
        public string KorisnickoIme { get; set; }
        public int UlogaID { get; set; }
        public int ParkingID { get; set; }
        public string Lozinka { get; set; }
    }
}
