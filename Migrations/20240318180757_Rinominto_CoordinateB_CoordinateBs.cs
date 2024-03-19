using Microsoft.EntityFrameworkCore.Migrations;

namespace MakeSense.Migrations
{
    public partial class Rinominto_CoordinateB_CoordinateBs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CoordinateB_Annotations_AnnotationId",
                table: "CoordinateB");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CoordinateB",
                table: "CoordinateB");

            migrationBuilder.RenameTable(
                name: "CoordinateB",
                newName: "CoordinateBs");

            migrationBuilder.RenameIndex(
                name: "IX_CoordinateB_AnnotationId",
                table: "CoordinateBs",
                newName: "IX_CoordinateBs_AnnotationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CoordinateBs",
                table: "CoordinateBs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CoordinateBs_Annotations_AnnotationId",
                table: "CoordinateBs",
                column: "AnnotationId",
                principalTable: "Annotations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CoordinateBs_Annotations_AnnotationId",
                table: "CoordinateBs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CoordinateBs",
                table: "CoordinateBs");

            migrationBuilder.RenameTable(
                name: "CoordinateBs",
                newName: "CoordinateB");

            migrationBuilder.RenameIndex(
                name: "IX_CoordinateBs_AnnotationId",
                table: "CoordinateB",
                newName: "IX_CoordinateB_AnnotationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CoordinateB",
                table: "CoordinateB",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CoordinateB_Annotations_AnnotationId",
                table: "CoordinateB",
                column: "AnnotationId",
                principalTable: "Annotations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
