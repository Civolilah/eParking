using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eParking.Database
{
    public class KorisnikUloga
    {
        [Key]
        public int KorisnikUlogaID { get; set; }
        public Korisnici Korisnik { get; set; }
        [ForeignKey("Korisnik")]
        public int KorisnikID { get; set; }
        public Uloge Uloga { get; set; }
        [ForeignKey("Uloga")]
        public int UlogaID { get; set; }
    }
}
