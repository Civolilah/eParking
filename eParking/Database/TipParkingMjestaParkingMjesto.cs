using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eParking.Database
{
    public class TipParkingMjestaParkingMjesto
    {
        [Key]
        public int TipParkingMjestaParkingMjestoID { get; set; }
        public TipParkingMijesta Tip { get; set; }
        [ForeignKey("Tip")]
        public int TipParkingMjestaID { get; set; }
        public ParkingMjesta ParkingMjesto { get; set; }
        [ForeignKey("ParkingMjesto")]
        public int ParkingMjestoID { get; set; }
    }
}
