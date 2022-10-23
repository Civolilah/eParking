using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eParking.Database
{
    public class KorisnikParking
    {
        [Key]
        public int KorisnikParkingID { get; set; }
        public Korisnici Korisnik { get; set; }
        [ForeignKey("Korisnik")]
        public int KorisnikID { get; set; }
        public Parkinzi Parking { get; set; }
        [ForeignKey("Parking")]
        public int ParkingID { get; set; }
    }
}
