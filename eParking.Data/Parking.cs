using System;
using System.Collections.Generic;
using System.Text;

namespace eParking.Data
{
    public class Parking
    {
        public int ParkingID { get; set; }
        public string Naziv { get; set; }
        public string XKoordinata { get; set; }
        public string YKoordinata { get; set; }
        public string RadnoVrijeme { get; set; }
        public Grad Grad { get; set; }
        public int GradID { get; set; }
    }
}
