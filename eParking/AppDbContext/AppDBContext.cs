using eParking.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartRestaurant.WebAPI
{
    public partial class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {
        }

        public DbSet<Korisnici> Korisnici { get; set; }
        public DbSet<Uloge> Uloge { get; set; }
        public DbSet<KorisnikUloga> KorisniciUloge { get; set; }
        public DbSet<Drzave> Drzave { get; set; }
        public DbSet<Gradovi> Gradovi { get; set; }
        public DbSet<ParkingMjesta> ParkingMjesta { get; set; }
        public DbSet<ParkingParkingMjesto> ParkingParkingMjesta { get; set; }
        public DbSet<Parkinzi> Parkinzi { get; set; }
        public DbSet<TipParkingMijesta> TipParkingMijesta { get; set; }
        public DbSet<TipParkingMjestaParkingMjesto> TipParkingMjestaParkingMjesta { get; set; }
        public DbSet<KorisnikParking> KorisnikParking { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            OnModelCreatingPartial(builder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
