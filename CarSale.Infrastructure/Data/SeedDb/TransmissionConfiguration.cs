using CarSale.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarSale.Infrastructure.Data.SeedDb
{
    internal class TransmissionConfiguration : IEntityTypeConfiguration<Transmission>
    {
        public void Configure(EntityTypeBuilder<Transmission> builder)
        {
            builder
                .HasMany(t => t.Offers)
                .WithOne(o => o.Transmission)
                .HasForeignKey(o => o.TransmissionId)
                .OnDelete(DeleteBehavior.Restrict);

            //builder.HasData(SeedTransmissions());
        }

        private List<Transmission> SeedTransmissions()
        {
            var transmissions = new List<Transmission>()
            {
                new Transmission { Id = 1, Name = "Automatic" },
                new Transmission { Id = 2, Name = "Manual" },
                new Transmission { Id = 3, Name = "Semi-automatic" }
            };

            return transmissions;
        }
    }
}
