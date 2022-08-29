using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_Entities.Migrations
{
    public partial class dbv10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Process2ProcessId",
                table: "Tickets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_Process2ProcessId",
                table: "Tickets",
                column: "Process2ProcessId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Processes_Process2ProcessId",
                table: "Tickets",
                column: "Process2ProcessId",
                principalTable: "Processes",
                principalColumn: "ProcessId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Processes_Process2ProcessId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_Process2ProcessId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Process2ProcessId",
                table: "Tickets");
        }
    }
}
