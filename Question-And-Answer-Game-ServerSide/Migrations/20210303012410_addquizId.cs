using Microsoft.EntityFrameworkCore.Migrations;

namespace Question_And_Answer_Game_ServerSide.Migrations
{
    public partial class addquizId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuizId",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuizId",
                table: "Questions");
        }
    }
}
