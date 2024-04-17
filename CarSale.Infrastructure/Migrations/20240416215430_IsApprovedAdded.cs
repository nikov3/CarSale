using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarSale.Infrastructure.Migrations
{
    public partial class IsApprovedAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Offers",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Offers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1708a3e-769c-4bcf-aff1-71702015951e", "AQAAAAEAACcQAAAAEPzmYnqpEj3ZIjZkDYV419wfeD2xDuMwn0ji8EPB4GU7ntxuBJfK2qpNCVxuj/qiuA==", "5fc8cca2-97ff-4113-aa93-087689da3cb0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2060b52c-ac15-4a70-9435-8b978af676ad", "AQAAAAEAACcQAAAAEBvlbAWNtWUUOwcfLsey3V/LYJBp8XKUjPTdE82Gn3tJnlJfJ6w7uwhbm73hRMBNOg==", "94213a1e-5a25-4563-8bed-9aea0447cb52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43827e2f-bc24-4e07-ac6c-de7fe0d9c52a", "AQAAAAEAACcQAAAAEBNGcZUlgSFkWcuQnlEohY2QmZuwx20WuOUMJRbkTVliAKrsTOasLBbIhmZFQamesw==", "83ba9f1a-5515-4598-a2aa-2dddb95ddd04" });
        }
    }
}
