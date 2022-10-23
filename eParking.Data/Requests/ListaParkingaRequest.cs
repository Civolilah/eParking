using System;
using System.Collections.Generic;
using System.Text;

namespace eParking.Data.Requests
{
    public class ListaParkingaRequest
    {
        public int GradID { get; set; }
        public double Lang { get; set; }
        public double Lat { get; set; }
    }
}
