using CarSale.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSale.Infrastructure.Data.SeedDb
{
    internal class OfferConfiguration : IEntityTypeConfiguration<Offer>
    {
        public void Configure(EntityTypeBuilder<Offer> builder)
        {
            builder
                .HasOne(o => o.Brand)
                .WithMany(b => b.Offers)
                .HasForeignKey(o => o.BrandId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
