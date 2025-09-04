using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Association.Data.Migrations
{
    public partial class con : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "DonorDb");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "DonationDb",
                newName: "KerenId");

            migrationBuilder.RenameColumn(
                name: "Keren",
                table: "DonationDb",
                newName: "DonorId");

            migrationBuilder.RenameColumn(
                name: "Donor",
                table: "DonationDb",
                newName: "DonationTypeId");

            migrationBuilder.AddColumn<int>(
                name: "CitiesId",
                table: "DonorDb",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DonationDb_DonorId",
                table: "DonationDb",
                column: "DonorId");

            migrationBuilder.AddForeignKey(
                name: "FK_DonationDb_DonorDb_DonorId",
                table: "DonationDb",
                column: "DonorId",
                principalTable: "DonorDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DonationDb_DonorDb_DonorId",
                table: "DonationDb");

            migrationBuilder.DropIndex(
                name: "IX_DonationDb_DonorId",
                table: "DonationDb");

            migrationBuilder.DropColumn(
                name: "CitiesId",
                table: "DonorDb");

            migrationBuilder.RenameColumn(
                name: "KerenId",
                table: "DonationDb",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "DonorId",
                table: "DonationDb",
                newName: "Keren");

            migrationBuilder.RenameColumn(
                name: "DonationTypeId",
                table: "DonationDb",
                newName: "Donor");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "DonorDb",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
