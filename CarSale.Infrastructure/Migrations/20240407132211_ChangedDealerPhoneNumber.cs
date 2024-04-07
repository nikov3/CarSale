using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarSale.Infrastructure.Migrations
{
    public partial class ChangedDealerPhoneNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactPhone",
                table: "Dealers");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Dealers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Dealers_PhoneNumber",
                table: "Dealers",
                column: "PhoneNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Dealers_PhoneNumber",
                table: "Dealers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Dealers");

            migrationBuilder.AddColumn<string>(
                name: "ContactPhone",
                table: "Dealers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);
        }
    }
}
