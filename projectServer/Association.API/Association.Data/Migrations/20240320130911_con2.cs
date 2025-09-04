using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Association.Data.Migrations
{
    public partial class con2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_DonorDb_CitiesId",
                table: "DonorDb",
                column: "CitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_DonationDb_DonationTypeId",
                table: "DonationDb",
                column: "DonationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DonationDb_KerenId",
                table: "DonationDb",
                column: "KerenId");

            migrationBuilder.AddForeignKey(
                name: "FK_DonationDb_DonationTypeDb_DonationTypeId",
                table: "DonationDb",
                column: "DonationTypeId",
                principalTable: "DonationTypeDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DonationDb_KerenDb_KerenId",
                table: "DonationDb",
                column: "KerenId",
                principalTable: "KerenDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DonorDb_CitiesDb_CitiesId",
                table: "DonorDb",
                column: "CitiesId",
                principalTable: "CitiesDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DonationDb_DonationTypeDb_DonationTypeId",
                table: "DonationDb");

            migrationBuilder.DropForeignKey(
                name: "FK_DonationDb_KerenDb_KerenId",
                table: "DonationDb");

            migrationBuilder.DropForeignKey(
                name: "FK_DonorDb_CitiesDb_CitiesId",
                table: "DonorDb");

            migrationBuilder.DropIndex(
                name: "IX_DonorDb_CitiesId",
                table: "DonorDb");

            migrationBuilder.DropIndex(
                name: "IX_DonationDb_DonationTypeId",
                table: "DonationDb");

            migrationBuilder.DropIndex(
                name: "IX_DonationDb_KerenId",
                table: "DonationDb");
        }
    }
}
