using CarSale.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSale.Infrastructure.Data.SeedDb
{
    internal class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var data = new SeedData();

            builder.HasData(new ApplicationUser[] { data.DealerUser, data.GuestUser, data.AdminUser});
        }

        //private List<ApplicationUser> SeedUsers()
        //{
        //    var users = new List<ApplicationUser>
        //    {
        //        new ApplicationUser
        //        {
        //            Id = "",
        //            UserName = "",
        //            NormalizedUserName = "",
        //            Email = "",
        //            NormalizedEmail = "",
        //            FirstName = "",
        //            LastName = ""
        //        },
        //        new ApplicationUser
        //        {
        //            Id = "",
        //            UserName = "",
        //            NormalizedUserName = "",
        //            Email = "",
        //            NormalizedEmail = "",
        //            FirstName = "",
        //            LastName = ""
        //        },
        //        new ApplicationUser
        //        {
        //            Id = "",
        //            UserName = "",
        //            NormalizedUserName = "",
        //            Email = "",
        //            NormalizedEmail = "",
        //            FirstName = "",
        //            LastName = ""
        //        }
        //    };

        //    return users;
        //}
    }
}
