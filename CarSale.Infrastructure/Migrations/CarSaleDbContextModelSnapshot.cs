﻿// <auto-generated />
using System;
using CarSale.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarSale.Infrastructure.Migrations
{
    [DbContext(typeof(CarSaleDbContext))]
    partial class CarSaleDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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

                    b.ToTable("Brands", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "All"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Audi"
                        },
                        new
                        {
                            Id = 3,
                            Name = "BMW"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Chevrolet"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Ferrari"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Ford"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Honda"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Hyundai"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Jaguar"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Kia"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Land Rover"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Lexus"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Mazda"
                        },
                        new
                        {
                            Id = 14,
                            Name = "MercedesBenz"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Nissan"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Porsche"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Subaru"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Tesla"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Toyota"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Volkswagen"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Volvo"
                        });
                });

            modelBuilder.Entity("CarSale.Data.Models.CarModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("CarModels", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            Name = "All"
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 2,
                            Name = "A1"
                        },
                        new
                        {
                            Id = 3,
                            BrandId = 2,
                            Name = "A2"
                        },
                        new
                        {
                            Id = 4,
                            BrandId = 2,
                            Name = "A3"
                        },
                        new
                        {
                            Id = 5,
                            BrandId = 2,
                            Name = "A4"
                        },
                        new
                        {
                            Id = 6,
                            BrandId = 2,
                            Name = "A5"
                        },
                        new
                        {
                            Id = 7,
                            BrandId = 2,
                            Name = "A6"
                        },
                        new
                        {
                            Id = 8,
                            BrandId = 2,
                            Name = "A7"
                        },
                        new
                        {
                            Id = 9,
                            BrandId = 2,
                            Name = "A8"
                        },
                        new
                        {
                            Id = 10,
                            BrandId = 3,
                            Name = "1er"
                        },
                        new
                        {
                            Id = 11,
                            BrandId = 3,
                            Name = "2er"
                        },
                        new
                        {
                            Id = 12,
                            BrandId = 3,
                            Name = "3er"
                        },
                        new
                        {
                            Id = 13,
                            BrandId = 3,
                            Name = "4er"
                        },
                        new
                        {
                            Id = 14,
                            BrandId = 3,
                            Name = "5er"
                        },
                        new
                        {
                            Id = 15,
                            BrandId = 3,
                            Name = "6er"
                        },
                        new
                        {
                            Id = 16,
                            BrandId = 3,
                            Name = "7er"
                        },
                        new
                        {
                            Id = 17,
                            BrandId = 3,
                            Name = "8er"
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

                    b.ToTable("Types", (string)null);

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

                    b.ToTable("Cities", (string)null);

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

                    b.ToTable("Colors", (string)null);

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

                    b.ToTable("Dealers", (string)null);
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

                    b.ToTable("Fuels", (string)null);

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

                    b.Property<int>("CarModelId")
                        .HasColumnType("int");

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

                    b.Property<string>("Desription")
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

                    b.HasIndex("CarModelId");

                    b.HasIndex("CarTypeId");

                    b.HasIndex("CityId");

                    b.HasIndex("ColorId");

                    b.HasIndex("DealerId");

                    b.HasIndex("FuelId");

                    b.HasIndex("TransmissionId");

                    b.ToTable("Offers", (string)null);
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

                    b.ToTable("Transmissions", (string)null);

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
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

            modelBuilder.Entity("CarSale.Data.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("CarSale.Data.Models.CarModel", b =>
                {
                    b.HasOne("CarSale.Data.Models.Brand", "Brand")
                        .WithMany("CarModels")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Brand");
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

                    b.HasOne("CarSale.Data.Models.CarModel", "CarModel")
                        .WithMany("Offers")
                        .HasForeignKey("CarModelId")
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

                    b.Navigation("CarModel");

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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarSale.Data.Models.Brand", b =>
                {
                    b.Navigation("CarModels");

                    b.Navigation("Offers");
                });

            modelBuilder.Entity("CarSale.Data.Models.CarModel", b =>
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
