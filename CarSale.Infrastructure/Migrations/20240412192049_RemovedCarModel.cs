using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarSale.Infrastructure.Migrations
{
    public partial class RemovedCarModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_CarModels_CarModelId",
                table: "Offers");

            migrationBuilder.DropTable(
                name: "CarModels");

            migrationBuilder.DropIndex(
                name: "IX_Offers_CarModelId",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "CarModelId",
                table: "Offers");

            migrationBuilder.AddColumn<string>(
                name: "CarModel",
                table: "Offers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarModel",
                table: "Offers");

            migrationBuilder.AddColumn<int>(
                name: "CarModelId",
                table: "Offers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CarModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarModels_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "Id", "BrandId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "All" },
                    { 2, 2, "A1" },
                    { 3, 2, "A2" },
                    { 4, 2, "A3" },
                    { 5, 2, "A4" },
                    { 6, 2, "A5" },
                    { 7, 2, "A6" },
                    { 8, 2, "A7" },
                    { 9, 2, "A8" },
                    { 10, 3, "1er" },
                    { 11, 3, "2er" },
                    { 12, 3, "3er" },
                    { 13, 3, "4er" },
                    { 14, 3, "5er" },
                    { 15, 3, "6er" },
                    { 16, 3, "7er" },
                    { 17, 3, "8er" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Offers_CarModelId",
                table: "Offers",
                column: "CarModelId");

            migrationBuilder.CreateIndex(
                name: "IX_CarModels_BrandId",
                table: "CarModels",
                column: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_CarModels_CarModelId",
                table: "Offers",
                column: "CarModelId",
                principalTable: "CarModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
