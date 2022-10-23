using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eParking.Database
{
    public class Drzave
    {
        [Key]
        public int DrzavaID { get; set; }
        public string Naziv { get; set; }
        public string Skracenica { get; set; }
    }
}
