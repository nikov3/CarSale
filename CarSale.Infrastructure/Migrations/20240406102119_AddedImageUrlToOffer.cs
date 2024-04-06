﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarSale.Infrastructure.Migrations
{
    public partial class AddedImageUrlToOffer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Offers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Offers");
        }
    }
}
