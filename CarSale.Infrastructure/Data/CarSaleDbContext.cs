using CarSale.Data.Models;
using CarSale.Infrastructure.Data.SeedDb;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarSale.Infrastructure.Data
{
    public class CarSaleDbContext : IdentityDbContext
    {
        public CarSaleDbContext(DbContextOptions<CarSaleDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new BrandConfiguration());
            builder.ApplyConfiguration(new CarModelConfiguration());
            builder.ApplyConfiguration(new CarTypeConfiguration());
            builder.ApplyConfiguration(new CityConfiguration());
            builder.ApplyConfiguration(new ColorConfiguration());
            builder.ApplyConfiguration(new DealerConfiguration());
            builder.ApplyConfiguration(new FuelConfiguration());
            builder.ApplyConfiguration(new TransmissionConfiguration());

            base.OnModelCreating(builder);
        }


        public DbSet<ApplicationUser> Buyers { get; set; } = null!;
        public DbSet<Brand> Brands { get; set; } = null!;
        public DbSet<Dealer> Dealers  { get; set; } = null!;
        public DbSet<CarModel> CarModels { get; set; } = null!;
        public DbSet<Offer> Offers { get; set; } = null!; 
        public DbSet<CarType> Types { get; set; } = null!;
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<Color> Colors { get; set; } = null!;
        public DbSet<Fuel> Fuels { get; set; } = null!;
        public DbSet<Transmission> Transmissions { get; set; } = null!;

    }
}
