using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MakeSense.Migrations
{
    public partial class UsersApprovedBy_n_1_UsersIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_users_UserId",
                table: "users",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_users_users_UserId",
                table: "users",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_users_UserId",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_users_UserId",
                table: "users");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "users");
        }
    }
}
