using CarSale.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarSale.Infrastructure.Data.SeedDb
{
    internal class CarTypeConfiguration : IEntityTypeConfiguration<CarType>
    {
        public void Configure(EntityTypeBuilder<CarType> builder)
        {
            builder
                .HasMany(ct => ct.Offers)
                .WithOne(o => o.CarType)
                .HasForeignKey(o => o.CarTypeId)
                .OnDelete(DeleteBehavior.Restrict);
            
            //builder.HasData(SeedCarType());
        }

        private List<CarType> SeedCarType()
        {
            var carTypes = new List<CarType>()
            {
                new CarType { Id = 1, Name = "Convertible" },
                new CarType { Id = 2, Name = "Coupe" },
                new CarType { Id = 3, Name = "Hatchback" },
                new CarType { Id = 4, Name = "SUV" },
                new CarType { Id = 5, Name = "Sedan" },
                new CarType { Id = 6, Name = "Wagon" }
            };

            return carTypes;
        }
    }
}