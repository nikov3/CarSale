using CarSale.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarSale.Infrastructure.Data.SeedDb
{
    internal class ColorConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder
                .HasMany(c => c.Offers)
                .WithOne(o => o.Color)
                .HasForeignKey(o => o.ColorId)
                .OnDelete(DeleteBehavior.Restrict);
            
            //builder.HasData(SeedColor());
        }

        private List<Color> SeedColor()
        {
            var colors = new List<Color>()
            {
                new Color { Id = 1, Name = "Black" },
                new Color { Id = 2, Name = "Brown" },
                new Color { Id = 3, Name = "Blue" },
                new Color { Id = 4, Name = "Gray" },
                new Color { Id = 5, Name = "Green" },
                new Color { Id = 6, Name = "Orange" },
                new Color { Id = 7, Name = "Pink" },
                new Color { Id = 8, Name = "Red" },
                new Color { Id = 9, Name = "Yellow" },
                new Color { Id = 10, Name = "White" }
            };

            return colors;
        }
    }
}
