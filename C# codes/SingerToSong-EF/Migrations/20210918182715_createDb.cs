using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SingerToSong_EF.Migrations
{
    public partial class createDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SingerList",
                columns: table => new
                {
                    SingerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SingerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SingerSurname = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ActiveSince = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SingerList", x => x.SingerId);
                });

            migrationBuilder.CreateTable(
                name: "AlbumRecords",
                columns: table => new
                {
                    AlbumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SingerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumRecords", x => x.AlbumId);
                    table.ForeignKey(
                        name: "FK_AlbumRecords_SingerList_SingerId",
                        column: x => x.SingerId,
                        principalTable: "SingerList",
                        principalColumn: "SingerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Length = table.Column<int>(type: "int", nullable: false),
                    AlbumId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Songs_AlbumRecords_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "AlbumRecords",
                        principalColumn: "AlbumId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlbumRecords_SingerId",
                table: "AlbumRecords",
                column: "SingerId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_AlbumId",
                table: "Songs",
                column: "AlbumId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "AlbumRecords");

            migrationBuilder.DropTable(
                name: "SingerList");
        }
    }
}
