using Microsoft.EntityFrameworkCore.Migrations;

namespace MakeSense.Migrations
{
    public partial class table_Root_database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "RootId",
                table: "Image",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "roots",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roots", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Image_RootId",
                table: "Image",
                column: "RootId");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_roots_RootId",
                table: "Image",
                column: "RootId",
                principalTable: "roots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_roots_RootId",
                table: "Image");

            migrationBuilder.DropTable(
                name: "roots");

            migrationBuilder.DropIndex(
                name: "IX_Image_RootId",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "RootId",
                table: "Image");
        }
    }
}
