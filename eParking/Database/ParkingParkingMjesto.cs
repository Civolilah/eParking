using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eParking.Database
{
    public class ParkingParkingMjesto
    {
        [Key]
        public int TipParkingMjestaParkingMjestoID { get; set; }
        public Parkinzi Parking { get; set; }
        [ForeignKey("Parking")]
        public int ParkingID { get; set; }
        public ParkingMjesta ParkingMjesto { get; set; }
        [ForeignKey("ParkingMjesto")]
        public int ParkingMjestoID { get; set; }
    }
}
