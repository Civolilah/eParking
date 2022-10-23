using System;
using System.Collections.Generic;
using System.Text;

namespace eParking.Data.Requests
{
    public class UrediKorisnikaRequest
    {
        public int KorisnikID { get; set; }
        public string KorisnickoIme { get; set; }
        public int UlogaID { get; set; }
        public int ParkingID { get; set; }
        public string StariPassword { get; set; }
        public string NoviPassoword { get; set; }
    }
}
