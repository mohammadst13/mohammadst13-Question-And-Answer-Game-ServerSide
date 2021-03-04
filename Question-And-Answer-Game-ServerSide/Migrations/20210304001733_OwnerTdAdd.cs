using Microsoft.EntityFrameworkCore.Migrations;

namespace Question_And_Answer_Game_ServerSide.Migrations
{
    public partial class OwnerTdAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "Quizzes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Quizzes");
        }
    }
}
