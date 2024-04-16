﻿// <auto-generated />
using System;
using CarSale.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarSale.Infrastructure.Migrations
{
    [DbContext(typeof(CarSaleDbContext))]
    [Migration("20240416182345_UsersSeeded")]
    partial class UsersSeeded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CarSale.Data.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "dea12856-c198-4129-b3f3-b893d8395082",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2060b52c-ac15-4a70-9435-8b978af676ad",
                            Email = "dealer@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Dealer",
                            LastName = "Dealerov",
                            LockoutEnabled = false,
                            NormalizedEmail = "DEALER@MAIL.COM",
                            NormalizedUserName = "DEALER@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBvlbAWNtWUUOwcfLsey3V/LYJBp8XKUjPTdE82Gn3tJnlJfJ6w7uwhbm73hRMBNOg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "94213a1e-5a25-4563-8bed-9aea0447cb52",
                            TwoFactorEnabled = false,
                            UserName = "dealer@mail.com"
                        },
                        new
                        {
                            Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c1708a3e-769c-4bcf-aff1-71702015951e",
                            Email = "guest@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Guest",
                            LastName = "Guestov",
                            LockoutEnabled = false,
                            NormalizedEmail = "GUEST@MAIL.COM",
                            NormalizedUserName = "GUEST@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPzmYnqpEj3ZIjZkDYV419wfeD2xDuMwn0ji8EPB4GU7ntxuBJfK2qpNCVxuj/qiuA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5fc8cca2-97ff-4113-aa93-087689da3cb0",
                            TwoFactorEnabled = false,
                            UserName = "guest@mail.com"
                        },
                        new
                        {
                            Id = "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "43827e2f-bc24-4e07-ac6c-de7fe0d9c52a",
                            Email = "admin@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Great",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@MAIL.COM",
                            NormalizedUserName = "ADMIN@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBNGcZUlgSFkWcuQnlEohY2QmZuwx20WuOUMJRbkTVliAKrsTOasLBbIhmZFQamesw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "83ba9f1a-5515-4598-a2aa-2dddb95ddd04",
                            TwoFactorEnabled = false,
                            UserName = "admin@mail.com"
                        });
                });

            modelBuilder.Entity("CarSale.Data.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Audi"
                        },
                        new
                        {
                            Id = 2,
                            Name = "BMW"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Chevrolet"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Ferrari"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Ford"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Honda"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Hyundai"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Jaguar"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Kia"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Land Rover"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Lexus"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Mazda"
                        },
                        new
                        {
                            Id = 13,
                            Name = "MercedesBenz"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Nissan"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Porsche"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Subaru"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Tesla"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Toyota"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Volkswagen"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Volvo"
                        });
                });

            modelBuilder.Entity("CarSale.Data.Models.CarType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Types");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Convertible"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Coupe"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Hatchback"
                        },
                        new
                        {
                            Id = 4,
                            Name = "SUV"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Sedan"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Wagon"
                        });
                });

            modelBuilder.Entity("CarSale.Data.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Sofia"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Plovdiv"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Varna"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Burgas"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Ruse"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Stara Zagora"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Pleven"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Sliven"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Dobrich"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Shumen"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Veliko Tarnovo"
                        });
                });

            modelBuilder.Entity("CarSale.Data.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Black"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Brown"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Blue"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Gray"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Green"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Orange"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Pink"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Red"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Yellow"
                        },
                        new
                        {
                            Id = 10,
                            Name = "White"
                        });
                });

            modelBuilder.Entity("CarSale.Data.Models.Dealer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PhoneNumber")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Dealers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PhoneNumber = "+359888000888",
                            UserId = "dea12856-c198-4129-b3f3-b893d8395082"
                        },
                        new
                        {
                            Id = 2,
                            PhoneNumber = "+359888000777",
                            UserId = "e43ce836-997d-4927-ac59-74e8c41bbfd3"
                        });
                });

            modelBuilder.Entity("CarSale.Data.Models.Fuel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Fuels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Gasoline"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Diesel"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Hybrid"
                        },
                        new
                        {
                            Id = 4,
                            Name = "EV"
                        });
                });

            modelBuilder.Entity("CarSale.Data.Models.Offer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("CarModel")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("CarTypeId")
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("DealerId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("FuelId")
                        .HasColumnType("int");

                    b.Property<int>("HorsePower")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Milage")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TransmissionId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CarTypeId");

                    b.HasIndex("CityId");

                    b.HasIndex("ColorId");

                    b.HasIndex("DealerId");

                    b.HasIndex("FuelId");

                    b.HasIndex("TransmissionId");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("CarSale.Data.Models.Transmission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Transmissions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Automatic"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Manual"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Semi-automatic"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("CarSale.Data.Models.Dealer", b =>
                {
                    b.HasOne("CarSale.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CarSale.Data.Models.Offer", b =>
                {
                    b.HasOne("CarSale.Data.Models.Brand", "Brand")
                        .WithMany("Offers")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CarSale.Data.Models.CarType", "CarType")
                        .WithMany("Offers")
                        .HasForeignKey("CarTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CarSale.Data.Models.City", "City")
                        .WithMany("Offers")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CarSale.Data.Models.Color", "Color")
                        .WithMany("Offers")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CarSale.Data.Models.Dealer", "Dealer")
                        .WithMany("Offers")
                        .HasForeignKey("DealerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CarSale.Data.Models.Fuel", "Fuel")
                        .WithMany("Offers")
                        .HasForeignKey("FuelId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CarSale.Data.Models.Transmission", "Transmission")
                        .WithMany("Offers")
                        .HasForeignKey("TransmissionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("CarType");

                    b.Navigation("City");

                    b.Navigation("Color");

                    b.Navigation("Dealer");

                    b.Navigation("Fuel");

                    b.Navigation("Transmission");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CarSale.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CarSale.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarSale.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CarSale.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarSale.Data.Models.Brand", b =>
                {
                    b.Navigation("Offers");
                });

            modelBuilder.Entity("CarSale.Data.Models.CarType", b =>
                {
                    b.Navigation("Offers");
                });

            modelBuilder.Entity("CarSale.Data.Models.City", b =>
                {
                    b.Navigation("Offers");
                });

            modelBuilder.Entity("CarSale.Data.Models.Color", b =>
                {
                    b.Navigation("Offers");
                });

            modelBuilder.Entity("CarSale.Data.Models.Dealer", b =>
                {
                    b.Navigation("Offers");
                });

            modelBuilder.Entity("CarSale.Data.Models.Fuel", b =>
                {
                    b.Navigation("Offers");
                });

            modelBuilder.Entity("CarSale.Data.Models.Transmission", b =>
                {
                    b.Navigation("Offers");
                });
#pragma warning restore 612, 618
        }
    }
}
