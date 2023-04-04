using Microsoft.EntityFrameworkCore.Migrations;

namespace Album_Songs_EF.Migrations
{
    public partial class updatingColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Albums",
                table: "Albums");

            migrationBuilder.RenameTable(
                name: "Albums",
                newName: "AlbumRecords");

            migrationBuilder.RenameColumn(
                name: "Released",
                table: "AlbumRecords",
                newName: "ReleaseDate");

            migrationBuilder.AlterColumn<string>(
                name: "AlbumName",
                table: "AlbumRecords",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AlbumRecords",
                table: "AlbumRecords",
                column: "AlbumId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AlbumRecords",
                table: "AlbumRecords");

            migrationBuilder.RenameTable(
                name: "AlbumRecords",
                newName: "Albums");

            migrationBuilder.RenameColumn(
                name: "ReleaseDate",
                table: "Albums",
                newName: "Released");

            migrationBuilder.AlterColumn<string>(
                name: "AlbumName",
                table: "Albums",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Albums",
                table: "Albums",
                column: "AlbumId");
        }
    }
}
