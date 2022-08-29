using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_Entities.Migrations
{
    public partial class dbv4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Question_Answer_AnswerId",
                table: "Answer_Question");

            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Question_Question_QuestionId",
                table: "Answer_Question");

            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Question_Surveys_Answer_QuestionId",
                table: "Answer_Question");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Question",
                table: "Question");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Answer_Question",
                table: "Answer_Question");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Answer",
                table: "Answer");

            migrationBuilder.RenameTable(
                name: "Question",
                newName: "Questions");

            migrationBuilder.RenameTable(
                name: "Answer_Question",
                newName: "Answer_Questions");

            migrationBuilder.RenameTable(
                name: "Answer",
                newName: "Answers");

            migrationBuilder.RenameIndex(
                name: "IX_Answer_Question_QuestionId",
                table: "Answer_Questions",
                newName: "IX_Answer_Questions_QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_Answer_Question_AnswerId",
                table: "Answer_Questions",
                newName: "IX_Answer_Questions_AnswerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questions",
                table: "Questions",
                column: "QuestionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Answer_Questions",
                table: "Answer_Questions",
                column: "Answer_QuestionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Answers",
                table: "Answers",
                column: "AnswerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Questions_Answers_AnswerId",
                table: "Answer_Questions",
                column: "AnswerId",
                principalTable: "Answers",
                principalColumn: "AnswerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Questions_Questions_QuestionId",
                table: "Answer_Questions",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Questions_Surveys_Answer_QuestionId",
                table: "Answer_Questions",
                column: "Answer_QuestionId",
                principalTable: "Surveys",
                principalColumn: "SurveyId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Questions_Answers_AnswerId",
                table: "Answer_Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Questions_Questions_QuestionId",
                table: "Answer_Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Questions_Surveys_Answer_QuestionId",
                table: "Answer_Questions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Questions",
                table: "Questions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Answers",
                table: "Answers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Answer_Questions",
                table: "Answer_Questions");

            migrationBuilder.RenameTable(
                name: "Questions",
                newName: "Question");

            migrationBuilder.RenameTable(
                name: "Answers",
                newName: "Answer");

            migrationBuilder.RenameTable(
                name: "Answer_Questions",
                newName: "Answer_Question");

            migrationBuilder.RenameIndex(
                name: "IX_Answer_Questions_QuestionId",
                table: "Answer_Question",
                newName: "IX_Answer_Question_QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_Answer_Questions_AnswerId",
                table: "Answer_Question",
                newName: "IX_Answer_Question_AnswerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Question",
                table: "Question",
                column: "QuestionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Answer",
                table: "Answer",
                column: "AnswerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Answer_Question",
                table: "Answer_Question",
                column: "Answer_QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Question_Answer_AnswerId",
                table: "Answer_Question",
                column: "AnswerId",
                principalTable: "Answer",
                principalColumn: "AnswerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Question_Question_QuestionId",
                table: "Answer_Question",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Question_Surveys_Answer_QuestionId",
                table: "Answer_Question",
                column: "Answer_QuestionId",
                principalTable: "Surveys",
                principalColumn: "SurveyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
