using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalData.Migrations
{
    public partial class secondRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PatientAccounts_PersonId",
                table: "PatientAccounts");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAccounts_PersonId",
                table: "PatientAccounts",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PatientAccounts_PersonId",
                table: "PatientAccounts");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAccounts_PersonId",
                table: "PatientAccounts",
                column: "PersonId",
                unique: true);
        }
    }
}
