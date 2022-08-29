using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Test_Entities.Migrations
{
    public partial class dbv8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Questions_Surveys_Answer_QuestionId",
                table: "Answer_Questions");

            migrationBuilder.AlterColumn<int>(
                name: "Answer_QuestionId",
                table: "Answer_Questions",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "SurveyId",
                table: "Answer_Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Answer_Questions_SurveyId",
                table: "Answer_Questions",
                column: "SurveyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Questions_Surveys_SurveyId",
                table: "Answer_Questions",
                column: "SurveyId",
                principalTable: "Surveys",
                principalColumn: "SurveyId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Questions_Surveys_SurveyId",
                table: "Answer_Questions");

            migrationBuilder.DropIndex(
                name: "IX_Answer_Questions_SurveyId",
                table: "Answer_Questions");

            migrationBuilder.DropColumn(
                name: "SurveyId",
                table: "Answer_Questions");

            migrationBuilder.AlterColumn<int>(
                name: "Answer_QuestionId",
                table: "Answer_Questions",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

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
