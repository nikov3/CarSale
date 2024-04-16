using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarSale.Infrastructure.Migrations
{
    public partial class UsersSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "c1708a3e-769c-4bcf-aff1-71702015951e", "guest@mail.com", false, "Guest", "Guestov", false, null, "GUEST@MAIL.COM", "GUEST@MAIL.COM", "AQAAAAEAACcQAAAAEPzmYnqpEj3ZIjZkDYV419wfeD2xDuMwn0ji8EPB4GU7ntxuBJfK2qpNCVxuj/qiuA==", null, false, "5fc8cca2-97ff-4113-aa93-087689da3cb0", false, "guest@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dea12856-c198-4129-b3f3-b893d8395082", 0, "2060b52c-ac15-4a70-9435-8b978af676ad", "dealer@mail.com", false, "Dealer", "Dealerov", false, null, "DEALER@MAIL.COM", "DEALER@MAIL.COM", "AQAAAAEAACcQAAAAEBvlbAWNtWUUOwcfLsey3V/LYJBp8XKUjPTdE82Gn3tJnlJfJ6w7uwhbm73hRMBNOg==", null, false, "94213a1e-5a25-4563-8bed-9aea0447cb52", false, "dealer@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e43ce836-997d-4927-ac59-74e8c41bbfd3", 0, "43827e2f-bc24-4e07-ac6c-de7fe0d9c52a", "admin@mail.com", false, "Great", "Admin", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEBNGcZUlgSFkWcuQnlEohY2QmZuwx20WuOUMJRbkTVliAKrsTOasLBbIhmZFQamesw==", null, false, "83ba9f1a-5515-4598-a2aa-2dddb95ddd04", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "Dealers",
                columns: new[] { "Id", "PhoneNumber", "UserId" },
                values: new object[] { 1, "+359888000888", "dea12856-c198-4129-b3f3-b893d8395082" });

            migrationBuilder.InsertData(
                table: "Dealers",
                columns: new[] { "Id", "PhoneNumber", "UserId" },
                values: new object[] { 2, "+359888000777", "e43ce836-997d-4927-ac59-74e8c41bbfd3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e");

            migrationBuilder.DeleteData(
                table: "Dealers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dealers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3");
        }
    }
}
