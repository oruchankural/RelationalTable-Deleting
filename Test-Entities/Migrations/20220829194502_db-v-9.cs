using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Test_Entities.Migrations
{
    public partial class dbv9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProcessId",
                table: "Tickets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Processes",
                columns: table => new
                {
                    ProcessId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ProcessDescription = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processes", x => x.ProcessId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ProcessId",
                table: "Tickets",
                column: "ProcessId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Processes_ProcessId",
                table: "Tickets",
                column: "ProcessId",
                principalTable: "Processes",
                principalColumn: "ProcessId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Processes_ProcessId",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "Processes");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_ProcessId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "ProcessId",
                table: "Tickets");
        }
    }
}
