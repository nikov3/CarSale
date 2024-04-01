using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarSale.Infrastructure.Migrations
{
    public partial class CorrectedTransmission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Transmitions_TransmissionId",
                table: "Offers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transmitions",
                table: "Transmitions");

            migrationBuilder.RenameTable(
                name: "Transmitions",
                newName: "Transmissions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transmissions",
                table: "Transmissions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Transmissions_TransmissionId",
                table: "Offers",
                column: "TransmissionId",
                principalTable: "Transmissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Transmissions_TransmissionId",
                table: "Offers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transmissions",
                table: "Transmissions");

            migrationBuilder.RenameTable(
                name: "Transmissions",
                newName: "Transmitions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transmitions",
                table: "Transmitions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Transmitions_TransmissionId",
                table: "Offers",
                column: "TransmissionId",
                principalTable: "Transmitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
