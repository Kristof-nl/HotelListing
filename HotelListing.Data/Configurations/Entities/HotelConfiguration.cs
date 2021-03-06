using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Data.Configurations.Entities
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
                    Address = "Negril",
                    Rating = 4.5,
                    CountryId = 1
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Grand Palladium",
                    Address = "Nassau",
                    Rating = 4,
                    CountryId = 2
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Comfort Suits ",
                    Address = "George Town",
                    Rating = 4.3,
                    CountryId = 3
                }
            );
        }
    }
}
