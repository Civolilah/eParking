using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Maps;

namespace eParking.Data.Requests
{
    public class IspisParkingaRequest
    {
        public int ParkingID { get; set; }
        public string Naziv { get; set; }
        public string RadnoVrijeme { get; set; }
        public int BrojZauzetihMijesta { get; set; }
        public int BrojSlobodnihMijesta { get; set; }
        public double XKoordinata { get; set; }
        public double YKoordinata { get; set; }
        public double TrenutnaUdaljenostOdParkinga { get; set; }
    }
}
