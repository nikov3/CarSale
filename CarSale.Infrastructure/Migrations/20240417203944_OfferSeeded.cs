using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarSale.Infrastructure.Migrations
{
    public partial class OfferSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Dealers_UserId",
                table: "Dealers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de3e8f7e-962c-40fa-89dd-249fdc2bb689", "AQAAAAEAACcQAAAAEPVRvqwMDjiSFKjlEbKYNbRYyOdGzzzHdIoCp8R0RlpGJX7Q5T9X9KN6/HpY42wpsA==", "01a7a4a6-7cfa-4e75-a8ff-c8f66a8d3a1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d26f85d-457a-4ebe-a3a4-d8bcd3eb5199", "AQAAAAEAACcQAAAAEPsZF4lNaDY0JF7PBv6JVAIXNvD+ZQvli3uTfJfA+Ytrnx5hCLQexuGYF5HkTRw1Lg==", "5a122dfd-9aef-4b51-bde7-a91434eedb11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa5267d9-71e8-4df1-a25b-d1d7d43b4330", "AQAAAAEAACcQAAAAEAwZGOOthIbJy/pP9EjqbIucOtCdH2QHempGaIwITR7bEvNJ+8TECZ/IG8j8vBkNxA==", "09eccd46-f565-4018-a9bd-1396df3d8b5a" });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "BrandId", "CarModel", "CarTypeId", "CityId", "ColorId", "CreatedOn", "DealerId", "Description", "FuelId", "HorsePower", "ImageUrl", "IsApproved", "Milage", "Price", "TransmissionId", "Year" },
                values: new object[,]
                {
                    { 1, 2, "335i", 2, 1, 1, new DateTime(2024, 4, 17, 23, 39, 44, 352, DateTimeKind.Local).AddTicks(499), 1, "Pure german engeniering", 1, 306, "https://i.pinimg.com/originals/cf/78/ce/cf78ce4b73039e7ecbabd63efd35b26d.jpg", true, 120000, 25000m, 1, 2010 },
                    { 2, 12, "MX-5 Miata", 1, 1, 1, new DateTime(2024, 4, 17, 23, 39, 44, 352, DateTimeKind.Local).AddTicks(520), 1, "Its a joy to drive", 1, 114, "https://upload.wikimedia.org/wikipedia/commons/thumb/a/af/Eunos.jpg/420px-Eunos.jpg", true, 250000, 10000m, 2, 1995 },
                    { 3, 2, "325i", 5, 1, 8, new DateTime(2024, 4, 17, 23, 39, 44, 352, DateTimeKind.Local).AddTicks(523), 1, "There is somthing else in the classics", 1, 192, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSL6DXjRVsT3VZbZJX-GpON_GIdHhNefGrq8w&s", true, 190000, 12000m, 2, 1992 },
                    { 4, 13, "C class", 5, 3, 1, new DateTime(2024, 4, 17, 23, 39, 44, 352, DateTimeKind.Local).AddTicks(526), 1, "The comfort of driving", 2, 204, "https://upload.wikimedia.org/wikipedia/commons/thumb/0/07/Mercedes-Benz_C_180_Kompressor_Avantgarde_%28W_204%29_%E2%80%93_Frontansicht%2C_14._April_2011%2C_Velbert.jpg/420px-Mercedes-Benz_C_180_Kompressor_Avantgarde_%28W_204%29_%E2%80%93_Frontansicht%2C_14._April_2011%2C_Velbert.jpg", true, 170000, 13000m, 1, 2009 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dealers_UserId",
                table: "Dealers",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Dealers_UserId",
                table: "Dealers");

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "610e08d7-9efc-4e8a-b1d2-1787678628a1", "AQAAAAEAACcQAAAAEH9PTOBqSAohb3p4RGxeiEJ799Osk8Z+IJ1BoSaI/Ht55LfXSClVqfbjlYjeHDALYQ==", "4897fe7d-a43d-42e7-9052-23c64a2f18b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f69567f1-5770-4d69-9d6a-f1052cc0a4bc", "AQAAAAEAACcQAAAAEHcDldHtNo0vkySUK2q10o40Ek5k0F6TLBFHKJxu+RdUqSsWNNJGHqIGoRhFE00F3w==", "7b169aa3-0423-46a7-9224-f3b340a81a1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d8e8db8-e663-43c0-b626-0992be5a693e", "AQAAAAEAACcQAAAAEI48Mu3ho0jGxEw6WIsDki1A7Ce5YEI2OokeLycGYsGdo1j6affnWzPr4DBBX5Xctg==", "e85a8c9d-6988-4b3b-bd92-7eb4592c73b7" });

            migrationBuilder.CreateIndex(
                name: "IX_Dealers_UserId",
                table: "Dealers",
                column: "UserId");
        }
    }
}
