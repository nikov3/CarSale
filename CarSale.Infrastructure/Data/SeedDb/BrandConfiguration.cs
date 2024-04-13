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

            builder.HasData(SeedBrands());
        }

        private List<Brand> SeedBrands()
        {
            var brands = new List<Brand>
            {
                new Brand { Id = 1, Name = "Audi" },
                new Brand { Id = 2, Name = "BMW" },
                new Brand { Id = 3, Name = "Chevrolet" },
                new Brand { Id = 4, Name = "Ferrari" },
                new Brand { Id = 5, Name = "Ford" },
                new Brand { Id = 6, Name = "Honda" },
                new Brand { Id = 7, Name = "Hyundai" },
                new Brand { Id = 8, Name = "Jaguar" },
                new Brand { Id = 9, Name = "Kia" },
                new Brand { Id = 10, Name = "Land Rover" },
                new Brand { Id = 11, Name = "Lexus" },
                new Brand { Id = 12, Name = "Mazda" },
                new Brand { Id = 13, Name = "MercedesBenz" },
                new Brand { Id = 14, Name = "Nissan" },
                new Brand { Id = 15, Name = "Porsche" },
                new Brand { Id = 16, Name = "Subaru" },
                new Brand { Id = 17, Name = "Tesla" },
                new Brand { Id = 18, Name = "Toyota" },
                new Brand { Id = 19, Name = "Volkswagen" },
                new Brand { Id = 20, Name = "Volvo" }
            };

            return brands;
        }

    }
}
