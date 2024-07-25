using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MakeSense.Migrations
{
    public partial class table_Image_Relazopme_User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "ApprovedById",
                table: "Image",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdUser",
                table: "Image",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Image_ApprovedById",
                table: "Image",
                column: "ApprovedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_users_ApprovedById",
                table: "Image",
                column: "ApprovedById",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_users_ApprovedById",
                table: "Image");

            migrationBuilder.DropIndex(
                name: "IX_Image_ApprovedById",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "ApprovedById",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "IdUser",
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
    }
}
