using System;
using System.Collections.Generic;
using System.Text;

namespace eParking.Data.Requests
{
    public class InsertGradRequest
    {
        public int DrzavaID { get; set; }
        public string NazivGrada { get; set; }
        public string Skracenica { get; set; }
    }
}
