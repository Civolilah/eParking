using System;
using System.Collections.Generic;
using System.Text;

namespace eParking.Data.Requests
{
    public class UrediParkingRequest
    {
        public string NazivParkinga { get; set; }
        public DateTime RadnoVrijemeOD { get; set; }
        public DateTime RadnoVrijemeDO { get; set; }
        public string Lat { get; set; }
        public string Lang { get; set; }
        public bool Aktivan { get; set; }
        public List<ListaParkingMijestaRequest> ListaParkingMijesta { get; set; }
    }
}
