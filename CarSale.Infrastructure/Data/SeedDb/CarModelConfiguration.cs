using CarSale.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarSale.Infrastructure.Data.SeedDb
{
    internal class CarModelConfiguration : IEntityTypeConfiguration<CarModel>
    {
        public void Configure(EntityTypeBuilder<CarModel> builder)
        {
            builder
               .HasMany(cm => cm.Offers)
               .WithOne(o => o.CarModel)
               .HasForeignKey(o => o.CarModelId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(SeedCarModels());
        }

        public List<CarModel> SeedCarModels()
        {
            var carModels = new List<CarModel>()
            {
                new CarModel { Id = 1, BrandId = 1, Name = "All" },
                new CarModel { Id = 2, BrandId = 2, Name = "A1" },
                new CarModel { Id = 3, BrandId = 2, Name = "A2" },
                new CarModel { Id = 4, BrandId = 2, Name = "A3" },
                new CarModel { Id = 5, BrandId = 2, Name = "A4" },
                new CarModel { Id = 6, BrandId = 2, Name = "A5" },
                new CarModel { Id = 7, BrandId = 2, Name = "A6" },
                new CarModel { Id = 8, BrandId = 2, Name = "A7" },
                new CarModel { Id = 9, BrandId = 2, Name = "A8" },
                new CarModel { Id = 10, BrandId = 3, Name = "1er" },
                new CarModel { Id = 11, BrandId = 3, Name = "2er" },
                new CarModel { Id = 12, BrandId = 3, Name = "3er" },
                new CarModel { Id = 13, BrandId = 3, Name = "4er" },
                new CarModel { Id = 14, BrandId = 3, Name = "5er" },
                new CarModel { Id = 15, BrandId = 3, Name = "6er" },
                new CarModel { Id = 16, BrandId = 3, Name = "7er" },
                new CarModel { Id = 17, BrandId = 3, Name = "8er" }
            };

            return carModels;
        }
    }
}
