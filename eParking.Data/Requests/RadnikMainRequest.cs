using System;
using System.Collections.Generic;
using System.Text;

namespace eParking.Data.Requests
{
    public class RadnikMainRequest
    {
        public string NazivParkinga { get; set; }
        public List<RadnikListaParkingMjestaRequest> ListaParkingMijesta { get; set; }
    }
}
