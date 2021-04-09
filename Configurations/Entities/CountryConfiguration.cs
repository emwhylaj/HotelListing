using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Configurations.Entities
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
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
        }
    }
}