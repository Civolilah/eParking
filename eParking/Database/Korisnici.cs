using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eParking.Database
{
    public class Korisnici
    {
        [Key]
        public int KorisnikID { get; set; }
        public string NazivKorisnika { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
    }
}
