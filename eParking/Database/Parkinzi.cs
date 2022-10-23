using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eParking.Database
{
    public class Parkinzi
    {
        [Key]
        public int ParkingID { get; set; }
        public string Naziv { get; set; }
        public string XKoordinata { get; set; }
        public string YKoordinata { get; set; }
        public DateTime RadnoVrijemeOD { get; set; }
        public DateTime RadnoVrijemeDO { get; set; }
        public Gradovi Grad { get; set; }
        [ForeignKey("Grad")]
        public int GradID { get; set; }
        public bool Aktivan { get; set; }
    }
}
