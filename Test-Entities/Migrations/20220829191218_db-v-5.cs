using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_Entities.Migrations
{
    public partial class dbv5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Questions_Surveys_Answer_QuestionId",
                table: "Answer_Questions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Answer_Questions",
                table: "Answer_Questions");

            migrationBuilder.DropColumn(
                name: "Answer_QuestionId",
                table: "Answer_Questions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Answer_QuestionId",
                table: "Answer_Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Answer_Questions",
                table: "Answer_Questions",
                column: "Answer_QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Questions_Surveys_Answer_QuestionId",
                table: "Answer_Questions",
                column: "Answer_QuestionId",
                principalTable: "Surveys",
                principalColumn: "SurveyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
