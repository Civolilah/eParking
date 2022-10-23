using System;
using System.Collections.Generic;
using System.Text;

namespace eParking.Data.Requests
{
    public class DeleteParkingRequest
    {
        public string NazivParkinga { get; set; }
        public int ParkingID { get; set; }
    }
}
