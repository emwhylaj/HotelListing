using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Configurations.Entities
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
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