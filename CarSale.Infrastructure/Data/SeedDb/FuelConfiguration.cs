using CarSale.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarSale.Infrastructure.Data.SeedDb
{
    internal class FuelConfiguration : IEntityTypeConfiguration<Fuel>
    {
        public void Configure(EntityTypeBuilder<Fuel> builder)
        {
            builder
                .HasMany(f => f.Offers)
                .WithOne(o => o.Fuel)
                .HasForeignKey(o => o.FuelId)
                .OnDelete(DeleteBehavior.Restrict);

            //builder.HasData(SeedFuel());
        }

        private List<Fuel> SeedFuel()
        {
            var fuels = new List<Fuel>() 
            {
                new Fuel { Id = 1, Name = "Gasoline" },
                new Fuel { Id = 2, Name = "Diesel" },
                new Fuel { Id = 3, Name = "Hybrid" },
                new Fuel { Id = 4, Name = "EV" }

            };

            return fuels;
        }
    }
}
