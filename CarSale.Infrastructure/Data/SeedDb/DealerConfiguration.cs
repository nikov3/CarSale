using CarSale.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarSale.Infrastructure.Data.SeedDb
{
    internal class DealerConfiguration : IEntityTypeConfiguration<Dealer>
    {
        public void Configure(EntityTypeBuilder<Dealer> builder)
        {
            builder
                .HasMany(d => d.Offers)
                .WithOne(o => o.Dealer)
                .HasForeignKey(o => o.DealerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
