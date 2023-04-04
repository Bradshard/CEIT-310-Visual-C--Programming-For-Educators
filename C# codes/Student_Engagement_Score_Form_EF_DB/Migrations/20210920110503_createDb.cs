using Microsoft.EntityFrameworkCore.Migrations;

namespace Student_Engagement_Score_Form_EF_DB.Migrations
{
    public partial class createDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentList",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    StudentSurname = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Contact_Adress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentList", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Engagements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EngagementName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoView = table.Column<int>(type: "int", nullable: false),
                    PageView = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engagements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Engagements_StudentList_StudentId",
                        column: x => x.StudentId,
                        principalTable: "StudentList",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Engagements_StudentId",
                table: "Engagements",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Engagements");

            migrationBuilder.DropTable(
                name: "StudentList");
        }
    }
}
