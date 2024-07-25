using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MakeSense.Migrations
{
    public partial class immagine_approvedBy_Molti_Utente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApprovedBy",
                table: "Image");

            migrationBuilder.AddColumn<Guid>(
                name: "ImageId",
                table: "users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_users_ImageId",
                table: "users",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_users_Image_ImageId",
                table: "users",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_Image_ImageId",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_users_ImageId",
                table: "users");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "users");

            migrationBuilder.AddColumn<string>(
                name: "ApprovedBy",
                table: "Image",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
