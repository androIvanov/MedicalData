using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalData.Migrations
{
    public partial class seventh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PatientAccounts",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    AppointmentID = table.Column<string>(type: "nchar(10)", nullable: true),
                    PatientAccountNumber = table.Column<string>(type: "nchar(255)", nullable: false),
                    PrimaryCareProvider = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    StudentIndicator = table.Column<bool>(type: "bit", nullable: false),
                    Facility = table.Column<string>(type: "nvarchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientAccounts", x => x.AccountId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientAccounts");
        }
    }
}
