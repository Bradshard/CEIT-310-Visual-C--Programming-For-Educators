using Microsoft.EntityFrameworkCore.Migrations;

namespace Album_Songs_EF.Migrations
{
    public partial class updateDba : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_AlbumRecords_ParentAlbumAlbumId",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_Songs_ParentAlbumAlbumId",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "ParentAlbumAlbumId",
                table: "Songs");

            migrationBuilder.AddColumn<int>(
                name: "AlbumId",
                table: "Songs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Songs_AlbumId",
                table: "Songs",
                column: "AlbumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_AlbumRecords_AlbumId",
                table: "Songs",
                column: "AlbumId",
                principalTable: "AlbumRecords",
                principalColumn: "AlbumId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_AlbumRecords_AlbumId",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_Songs_AlbumId",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "Songs");

            migrationBuilder.AddColumn<int>(
                name: "ParentAlbumAlbumId",
                table: "Songs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Songs_ParentAlbumAlbumId",
                table: "Songs",
                column: "ParentAlbumAlbumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_AlbumRecords_ParentAlbumAlbumId",
                table: "Songs",
                column: "ParentAlbumAlbumId",
                principalTable: "AlbumRecords",
                principalColumn: "AlbumId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
