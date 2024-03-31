using CarSale.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarSale.Infrastructure.Data.SeedDb
{
    internal class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder
                .HasMany(b => b.Offers)
                .WithOne(o => o.Brand)
                .HasForeignKey(o => o.BrandId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
               .HasMany(b => b.CarModels)
               .WithOne(cm => cm.Brand)
               .HasForeignKey(cm => cm.BrandId)
               .OnDelete(DeleteBehavior.Restrict);

            //builder.HasData(SeedBrands());
        }

        private List<Brand> SeedBrands()
        {
            var brands = new List<Brand>()
            {
                new Brand { Id = 1, Name = "All" },
                new Brand { Id = 2, Name = "Audi" },
                new Brand { Id = 3, Name = "BMW" },
                new Brand { Id = 4, Name = "Chevrolet" },
                new Brand { Id = 5, Name = "Ferrari" },
                new Brand { Id = 6, Name = "Ford" },
                new Brand { Id = 7, Name = "Honda" },
                new Brand { Id = 8, Name = "Hyundai" },
                new Brand { Id = 9, Name = "Jaguar" },
                new Brand { Id = 10, Name = "Kia" },
                new Brand { Id = 11, Name = "Land Rover" },
                new Brand { Id = 12, Name = "Lexus" },
                new Brand { Id = 13, Name = "Mazda" },
                new Brand { Id = 14, Name = "MercedesBenz" },
                new Brand { Id = 15, Name = "Nissan" },
                new Brand { Id = 16, Name = "Porsche" },
                new Brand { Id = 17, Name = "Subaru" },
                new Brand { Id = 18, Name = "Tesla" },
                new Brand { Id = 19, Name = "Toyota" },
                new Brand { Id = 20, Name = "Volkswagen" },
                new Brand { Id = 21, Name = "Volvo" }
            };

            return brands;
        }

    }
}
