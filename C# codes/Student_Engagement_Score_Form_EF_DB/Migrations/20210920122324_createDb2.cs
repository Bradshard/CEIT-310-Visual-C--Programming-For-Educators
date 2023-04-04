using Microsoft.EntityFrameworkCore.Migrations;

namespace Student_Engagement_Score_Form_EF_DB.Migrations
{
    public partial class createDb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentFullName",
                table: "StudentList");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StudentFullName",
                table: "StudentList",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
