using Microsoft.EntityFrameworkCore.Migrations;

namespace MakeSense.Migrations
{
    public partial class tabellaimmagineaggiornata2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DonationOn",
                table: "Image",
                newName: "ApprovedOn");

            migrationBuilder.AddColumn<int>(
                name: "PixelX",
                table: "Image",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PixelY",
                table: "Image",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PixelX",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "PixelY",
                table: "Image");

            migrationBuilder.RenameColumn(
                name: "ApprovedOn",
                table: "Image",
                newName: "DonationOn");
        }
    }
}
