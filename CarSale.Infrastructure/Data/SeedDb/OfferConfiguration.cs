using CarSale.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarSale.Infrastructure.Data.SeedDb
{
    internal class OfferConfiguration : IEntityTypeConfiguration<Offer>
    {
        public void Configure(EntityTypeBuilder<Offer> builder)
        {
            var data = new SeedData();

            builder.HasData(new Offer[] { data.Offer1, data.Offer2, data.Offer3, data.Offer4 });
        }
    }
}