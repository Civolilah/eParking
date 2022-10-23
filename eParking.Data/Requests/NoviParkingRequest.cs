using System;
using System.Collections.Generic;
using System.Text;

namespace eParking.Data.Requests
{
    public class NoviParkingRequest
    {
        public int ParkingID { get; set; }
        public string NazivParkinga { get; set; }
        public int GradID { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public DateTime RadnoVrijemeOD { get; set; }
        public DateTime RadnoVrijemeDO { get; set; }
        public bool Aktivan { get; set; }
    }
}
