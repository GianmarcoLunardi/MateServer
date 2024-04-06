using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MakeSense.Migrations
{
    public partial class Update_tabella_Image_UpdateBy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedById",
                table: "Image",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Image_UpdatedById",
                table: "Image",
                column: "UpdatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_user_UpdatedById",
                table: "Image",
                column: "UpdatedById",
                principalTable: "user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_user_UpdatedById",
                table: "Image");

            migrationBuilder.DropIndex(
                name: "IX_Image_UpdatedById",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Image");
        }
    }
}
