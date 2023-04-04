using Microsoft.EntityFrameworkCore.Migrations;

namespace Student_Engagement_Score_Form_EF_DB.Migrations
{
    public partial class createDb1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StudentFullName",
                table: "StudentList",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentFullName",
                table: "StudentList");
        }
    }
}
