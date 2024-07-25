using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MakeSense.Migrations
{
    public partial class table_Image_Relazopme_User_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_users_ApprovedById",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Image");

            migrationBuilder.RenameColumn(
                name: "ApprovedById",
                table: "Image",
                newName: "User");

            migrationBuilder.RenameIndex(
                name: "IX_Image_ApprovedById",
                table: "Image",
                newName: "IX_Image_User");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_users_User",
                table: "Image",
                column: "User",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_users_User",
                table: "Image");

            migrationBuilder.RenameColumn(
                name: "User",
                table: "Image",
                newName: "ApprovedById");

            migrationBuilder.RenameIndex(
                name: "IX_Image_User",
                table: "Image",
                newName: "IX_Image_ApprovedById");

            migrationBuilder.AddColumn<Guid>(
                name: "IdUser",
                table: "Image",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddForeignKey(
                name: "FK_Image_users_ApprovedById",
                table: "Image",
                column: "ApprovedById",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
