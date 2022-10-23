using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eParking.Database
{
    public class Gradovi
    {
        [Key]
        public int GradID { get; set; }
        public string Naziv { get; set; }
        public string Skracenica { get; set; }
        public Drzave Drzava { get; set; }
        [ForeignKey("Drzava")]
        public int DrzavaID { get; set; }
    }
}
