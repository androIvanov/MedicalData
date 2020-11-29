using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalData.Migrations
{
    public partial class thirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PatientAccountAccountId",
                table: "Diagnosis",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Diagnosis_PatientAccountAccountId",
                table: "Diagnosis",
                column: "PatientAccountAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Diagnosis_PatientAccounts_PatientAccountAccountId",
                table: "Diagnosis",
                column: "PatientAccountAccountId",
                principalTable: "PatientAccounts",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diagnosis_PatientAccounts_PatientAccountAccountId",
                table: "Diagnosis");

            migrationBuilder.DropIndex(
                name: "IX_Diagnosis_PatientAccountAccountId",
                table: "Diagnosis");

            migrationBuilder.DropColumn(
                name: "PatientAccountAccountId",
                table: "Diagnosis");
        }
    }
}
