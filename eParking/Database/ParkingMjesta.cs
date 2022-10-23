using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eParking.Database
{
    public class ParkingMjesta
    {
        [Key]
        public int ParkingMjestoID { get; set; }
        public string Naziv { get; set; }
        public bool Status { get; set; }
    }
}
