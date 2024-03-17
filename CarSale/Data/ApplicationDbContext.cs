using CarSale.Data.Entities;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;

namespace CarSale.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CarBrand>()
                .HasMany(brand => brand.CarOffers)
                .WithOne(offer => offer.CarBrand)
                .HasForeignKey(offer => offer.CarBrandId);

            modelBuilder.Entity<CarType>()
                .HasMany(type => type.CarOffers)
                .WithOne(offer => offer.CarType)
                .HasForeignKey(offer => offer.CarTypeId);

            modelBuilder.Entity<City>()
                .HasMany(city => city.CarOffers)
                .WithOne(offer => offer.City)
                .HasForeignKey(offer => offer.CityId);

            modelBuilder.Entity<CarColor>()
                .HasMany(color => color.CarOffers)
                .WithOne(offer => offer.Color)
                .HasForeignKey(offer => offer.ColorId);

            modelBuilder.Entity<Fuel>()
                .HasMany(fuel => fuel.CarOffers)
                .WithOne(offer => offer.Fuel)
                .HasForeignKey(offer => offer.FuelId);

            modelBuilder.Entity<Transmition>()
                .HasMany(trans => trans.CarOffers)
                .WithOne(offer => offer.Transmition)
                .HasForeignKey(offer => offer.TransmitionId);

            modelBuilder.Entity<CarDealer>()
                .HasMany(cd => cd.CarOffers)
                .WithOne(co => co.CarDealer)
                .HasForeignKey(co => co.CarDealerId);

			SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarBrand>().HasData(
                new CarBrand { Id = 1, Name = "Audi" },
                new CarBrand { Id = 2, Name = "BMW" },
                new CarBrand { Id = 3, Name = "Chevrolet" },
                new CarBrand { Id = 4, Name = "Ferrari" },
                new CarBrand { Id = 5, Name = "Ford" },
                new CarBrand { Id = 6, Name = "Honda" },
                new CarBrand { Id = 7, Name = "Hyundai" },
                new CarBrand { Id = 8, Name = "Jaguar" },
                new CarBrand { Id = 9, Name = "Kia" },
                new CarBrand { Id = 10, Name = "Land Rover" },
                new CarBrand { Id = 11, Name = "Lexus" },
                new CarBrand { Id = 12, Name = "Mazda" },
                new CarBrand { Id = 13, Name = "MercedesBenz" },
                new CarBrand { Id = 14, Name = "Nissan" },
                new CarBrand { Id = 15, Name = "Porsche" },
                new CarBrand { Id = 16, Name = "Subaru" },
                new CarBrand { Id = 17, Name = "Tesla" },
                new CarBrand { Id = 18, Name = "Toyota" },
                new CarBrand { Id = 19, Name = "Volkswagen" },
                new CarBrand { Id = 20, Name = "Volvo" }
            );

    //        modelBuilder.Entity<CarOffer>().HasData(
    //            new CarOffer 
    //            { 
    //                Id = 1,
    //                CarBrandId = 1,
    //                FuelId = 1,
				//	TransmitionId = 1,
				//	CarTypeId = 1,
				//	ColorId = 1,
				//	CityId = 1,
				//	Price = 10000,
				//	Year = 2020,
				//	Milage = 200000
				//}
    //        );
        }

        public DbSet<ApplicationUser> Buyers { get; set; }
        public DbSet<CarBrand> CarBrands { get; set; }
        public DbSet<CarDealer> CarDealers  { get; set; }
        //public DbSet<CarModel> CarModels { get; set; }
        public DbSet<CarOffer> CarOffers { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<CarColor> Colors { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<Transmition> Transmitions { get; set; }

    }
}
