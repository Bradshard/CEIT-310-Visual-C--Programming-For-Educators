using Microsoft.EntityFrameworkCore.Migrations;

namespace Album_Songs_EF.Migrations
{
    public partial class updateDbas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Length",
                table: "AlbumRecords");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Length",
                table: "AlbumRecords",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
