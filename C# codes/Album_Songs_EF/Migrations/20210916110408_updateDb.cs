using Microsoft.EntityFrameworkCore.Migrations;

namespace Album_Songs_EF.Migrations
{
    public partial class updateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Length = table.Column<int>(type: "int", nullable: false),
                    ParentAlbumAlbumId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Songs_AlbumRecords_ParentAlbumAlbumId",
                        column: x => x.ParentAlbumAlbumId,
                        principalTable: "AlbumRecords",
                        principalColumn: "AlbumId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Songs_ParentAlbumAlbumId",
                table: "Songs",
                column: "ParentAlbumAlbumId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Songs");
        }
    }
}
