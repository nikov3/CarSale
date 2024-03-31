using CarSale.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarSale.Infrastructure.Data.SeedDb
{
    internal class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder
                .HasMany(c => c.Offers)
                .WithOne(o => o.City)
                .HasForeignKey(o => o.CityId)
                .OnDelete(DeleteBehavior.Restrict);

            //builder.HasData(SeedCity());
        }

        private List<City> SeedCity()
        {
            var cities = new List<City>()
            {
                new City{Id = 1, Name = "Sofia"},
                new City{Id = 2, Name = "Plovdiv"},
                new City{Id = 3, Name = "Varna"},
                new City{Id = 4, Name = "Burgas"},
                new City{Id = 5, Name = "Ruse"},
                new City{Id = 6, Name = "Stara Zagora"},
                new City{Id = 7, Name = "Pleven"},
                new City{Id = 8, Name = "Sliven"},
                new City{Id = 9, Name = "Dobrich"},
                new City{Id = 10, Name = "Shumen"},
                new City{Id = 11, Name = "Veliko Tarnovo"}
            };

            return cities;
        }
    }
}
