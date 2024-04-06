using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MakeSense.Migrations
{
    public partial class Aggiungi_tabella_Annotation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AnnotationId",
                table: "Coordinates",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AnnotationId",
                table: "CoordinateB",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Annotations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    iscrowd = table.Column<bool>(type: "bit", nullable: true),
                    image_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    category_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    segmentation_text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Area = table.Column<float>(type: "real", nullable: true),
                    bbbox_string = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Annotations", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Coordinates_AnnotationId",
                table: "Coordinates",
                column: "AnnotationId");

            migrationBuilder.CreateIndex(
                name: "IX_CoordinateB_AnnotationId",
                table: "CoordinateB",
                column: "AnnotationId");

            migrationBuilder.AddForeignKey(
                name: "FK_CoordinateB_Annotations_AnnotationId",
                table: "CoordinateB",
                column: "AnnotationId",
                principalTable: "Annotations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Coordinates_Annotations_AnnotationId",
                table: "Coordinates",
                column: "AnnotationId",
                principalTable: "Annotations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CoordinateB_Annotations_AnnotationId",
                table: "CoordinateB");

            migrationBuilder.DropForeignKey(
                name: "FK_Coordinates_Annotations_AnnotationId",
                table: "Coordinates");

            migrationBuilder.DropTable(
                name: "Annotations");

            migrationBuilder.DropIndex(
                name: "IX_Coordinates_AnnotationId",
                table: "Coordinates");

            migrationBuilder.DropIndex(
                name: "IX_CoordinateB_AnnotationId",
                table: "CoordinateB");

            migrationBuilder.DropColumn(
                name: "AnnotationId",
                table: "Coordinates");

            migrationBuilder.DropColumn(
                name: "AnnotationId",
                table: "CoordinateB");
        }
    }
}
