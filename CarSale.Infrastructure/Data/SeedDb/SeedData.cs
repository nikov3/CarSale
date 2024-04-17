using CarSale.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace CarSale.Infrastructure.Data.SeedDb
{
    internal class SeedData
    {
        public ApplicationUser DealerUser { get; set; }

        public ApplicationUser GuestUser { get; set; }

        public ApplicationUser AdminUser { get; set; }

        public Dealer Dealer { get; set; }

        public Dealer AdminDealer { get; set; }

        public Offer Offer1 { get; set; }

        public Offer Offer2 { get; set; }

        public Offer Offer3 { get; set; }

        public Offer Offer4 { get; set; }


        public SeedData()
        {
            SeedUsers();
            SeedDealer();
            SeedOffer();
        }

        private void SeedUsers()
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            DealerUser = new ApplicationUser()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "dealer@mail.com",
                NormalizedUserName = "DEALER@MAIL.COM",
                Email = "dealer@mail.com",
                NormalizedEmail = "DEALER@MAIL.COM",
                FirstName = "Dealer",
                LastName = "Dealerov"
            };

            DealerUser.PasswordHash =
                 hasher.HashPassword(DealerUser, "dealer123");

            GuestUser = new ApplicationUser()
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "guest@mail.com",
                NormalizedUserName = "GUEST@MAIL.COM",
                Email = "guest@mail.com",
                NormalizedEmail = "GUEST@MAIL.COM",
                FirstName = "Guest",
                LastName = "Guestov"
            };

            GuestUser.PasswordHash =
            hasher.HashPassword(DealerUser, "guest123");

            AdminUser = new ApplicationUser()
            {
                Id = "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                UserName = "admin@mail.com",
                NormalizedUserName = "ADMIN@MAIL.COM",
                Email = "admin@mail.com",
                NormalizedEmail = "ADMIN@MAIL.COM",
                FirstName = "Great",
                LastName = "Admin"
            };

            AdminUser.PasswordHash =
            hasher.HashPassword(AdminUser, "admin123");
        }

        private void SeedDealer()
        {
            Dealer = new Dealer()
            {
                Id = 1,
                PhoneNumber = "+359888000888",
                UserId = DealerUser.Id
            };

            AdminDealer = new Dealer()
            {
                Id = 2,
                PhoneNumber = "+359888000777",
                UserId = AdminUser.Id
            };
        }

        private void SeedOffer()
        {
            Offer1 = new Offer()
            {
                Id = 1,
                DealerId = 1,
                BrandId = 2,
                FuelId = 1,
                TransmissionId = 1,
                CarTypeId = 2,
                ColorId = 1,
                CityId = 1,
                Price = 25000,
                Year = 2010,
                Milage = 120000,
                ImageUrl = "https://i.pinimg.com/originals/cf/78/ce/cf78ce4b73039e7ecbabd63efd35b26d.jpg",
                Description = "Pure german engeniering",
                CreatedOn = DateTime.Now,
                HorsePower = 306,
                CarModel = "335i",
                IsApproved = true
            };

            Offer2 = new Offer()
            {
                Id = 2,
                DealerId = 1,
                BrandId = 12,
                FuelId = 1,
                TransmissionId = 2,
                CarTypeId = 1,
                ColorId = 1,
                CityId = 1,
                Price = 10000,
                Year = 1995,
                Milage = 250000,
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/af/Eunos.jpg/420px-Eunos.jpg",
                Description = "Its a joy to drive",
                CreatedOn = DateTime.Now,
                HorsePower = 114,
                CarModel = "MX-5 Miata",
                IsApproved = true
            };

            Offer3 = new Offer()
            {
                Id = 3,
                DealerId = 1,
                BrandId = 2,
                FuelId = 1,
                TransmissionId = 2,
                CarTypeId = 5,
                ColorId = 8,
                CityId = 1,
                Price = 12000,
                Year = 1992,
                Milage = 190000,
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSL6DXjRVsT3VZbZJX-GpON_GIdHhNefGrq8w&s",
                Description = "There is somthing else in the classics",
                CreatedOn = DateTime.Now,
                HorsePower = 192,
                CarModel = "325i",
                IsApproved = true
            };

            Offer4 = new Offer()
            {
                Id = 4,
                DealerId = 1,
                BrandId = 13,
                FuelId = 2,
                TransmissionId = 1,
                CarTypeId = 5,
                ColorId = 1,
                CityId = 3,
                Price = 13000,
                Year = 2009,
                Milage = 170000,
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/07/Mercedes-Benz_C_180_Kompressor_Avantgarde_%28W_204%29_%E2%80%93_Frontansicht%2C_14._April_2011%2C_Velbert.jpg/420px-Mercedes-Benz_C_180_Kompressor_Avantgarde_%28W_204%29_%E2%80%93_Frontansicht%2C_14._April_2011%2C_Velbert.jpg",
                Description = "The comfort of driving",
                CreatedOn = DateTime.Now,
                HorsePower = 204,
                CarModel = "C class",
                IsApproved = true
            };
        }
    }
}