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

        public SeedData()
        {
            SeedUsers();
            SeedDealer();
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
    }
}