using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eParking.Database
{
    public class TipParkingMijesta
    {
        [Key]
        public int TipParkingMjestaID { get; set; }
        public string Naziv { get; set; }
    }
}
