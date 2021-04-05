using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Nigeria",
                    ShortName = "NGA"
                },
                 new Country
                 {
                     Id = 2,
                     Name = "Ghana",
                     ShortName = "GHA"
                 },
                  new Country
                  {
                      Id = 3,
                      Name = "England",
                      ShortName = "ENG"
                  }
                );
            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandals Resort and Spa",
                    Address = "Lagos",
                    CountryId = 1,
                    Rating = 4.5
                },
                 new Hotel
                 {
                     Id = 2,
                     Name = "Sweet Home",
                     Address = "Accra",
                     CountryId = 3,
                     Rating = 4.5
                 },
                  new Hotel
                  {
                      Id = 3,
                      Name = "Grand Pallidium",
                      Address = "Manchester",
                      CountryId = 2,
                      Rating = 4
                  }
                );
        }
    }
}