using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eParking.Database
{
    public class Uloge
    {
        [Key]
        public int UlogaID { get; set; }
        public string Naziv { get; set; }
    }
}
