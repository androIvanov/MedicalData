using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalData.Migrations
{
    public partial class firstCluster : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PatientAccountAccountId",
                table: "Visits",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CallsToActionsCode",
                table: "PtdScores",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientAccountAccountId",
                table: "PtdScores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientAccountAccountId",
                table: "NextOfKins",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientAccountAccountId",
                table: "Guarantors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Visits_PatientAccountAccountId",
                table: "Visits",
                column: "PatientAccountAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_PtdScores_CallsToActionsCode",
                table: "PtdScores",
                column: "CallsToActionsCode");

            migrationBuilder.CreateIndex(
                name: "IX_PtdScores_PatientAccountAccountId",
                table: "PtdScores",
                column: "PatientAccountAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Procedures_DiagnosisId",
                table: "Procedures",
                column: "DiagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_NextOfKins_PatientAccountAccountId",
                table: "NextOfKins",
                column: "PatientAccountAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Insurances_GuarantorId",
                table: "Insurances",
                column: "GuarantorId");

            migrationBuilder.CreateIndex(
                name: "IX_Guarantors_PatientAccountAccountId",
                table: "Guarantors",
                column: "PatientAccountAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Eligibility_InsuranceId",
                table: "Eligibility",
                column: "InsuranceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Eligibility_Insurances_InsuranceId",
                table: "Eligibility",
                column: "InsuranceId",
                principalTable: "Insurances",
                principalColumn: "InsuranceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Guarantors_PatientAccounts_PatientAccountAccountId",
                table: "Guarantors",
                column: "PatientAccountAccountId",
                principalTable: "PatientAccounts",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Insurances_Guarantors_GuarantorId",
                table: "Insurances",
                column: "GuarantorId",
                principalTable: "Guarantors",
                principalColumn: "GuarantorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NextOfKins_PatientAccounts_PatientAccountAccountId",
                table: "NextOfKins",
                column: "PatientAccountAccountId",
                principalTable: "PatientAccounts",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Procedures_Diagnosis_DiagnosisId",
                table: "Procedures",
                column: "DiagnosisId",
                principalTable: "Diagnosis",
                principalColumn: "DiagnosisId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PtdScores_CallsToActions_CallsToActionsCode",
                table: "PtdScores",
                column: "CallsToActionsCode",
                principalTable: "CallsToActions",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PtdScores_PatientAccounts_PatientAccountAccountId",
                table: "PtdScores",
                column: "PatientAccountAccountId",
                principalTable: "PatientAccounts",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_PatientAccounts_PatientAccountAccountId",
                table: "Visits",
                column: "PatientAccountAccountId",
                principalTable: "PatientAccounts",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Eligibility_Insurances_InsuranceId",
                table: "Eligibility");

            migrationBuilder.DropForeignKey(
                name: "FK_Guarantors_PatientAccounts_PatientAccountAccountId",
                table: "Guarantors");

            migrationBuilder.DropForeignKey(
                name: "FK_Insurances_Guarantors_GuarantorId",
                table: "Insurances");

            migrationBuilder.DropForeignKey(
                name: "FK_NextOfKins_PatientAccounts_PatientAccountAccountId",
                table: "NextOfKins");

            migrationBuilder.DropForeignKey(
                name: "FK_Procedures_Diagnosis_DiagnosisId",
                table: "Procedures");

            migrationBuilder.DropForeignKey(
                name: "FK_PtdScores_CallsToActions_CallsToActionsCode",
                table: "PtdScores");

            migrationBuilder.DropForeignKey(
                name: "FK_PtdScores_PatientAccounts_PatientAccountAccountId",
                table: "PtdScores");

            migrationBuilder.DropForeignKey(
                name: "FK_Visits_PatientAccounts_PatientAccountAccountId",
                table: "Visits");

            migrationBuilder.DropIndex(
                name: "IX_Visits_PatientAccountAccountId",
                table: "Visits");

            migrationBuilder.DropIndex(
                name: "IX_PtdScores_CallsToActionsCode",
                table: "PtdScores");

            migrationBuilder.DropIndex(
                name: "IX_PtdScores_PatientAccountAccountId",
                table: "PtdScores");

            migrationBuilder.DropIndex(
                name: "IX_Procedures_DiagnosisId",
                table: "Procedures");

            migrationBuilder.DropIndex(
                name: "IX_NextOfKins_PatientAccountAccountId",
                table: "NextOfKins");

            migrationBuilder.DropIndex(
                name: "IX_Insurances_GuarantorId",
                table: "Insurances");

            migrationBuilder.DropIndex(
                name: "IX_Guarantors_PatientAccountAccountId",
                table: "Guarantors");

            migrationBuilder.DropIndex(
                name: "IX_Eligibility_InsuranceId",
                table: "Eligibility");

            migrationBuilder.DropColumn(
                name: "PatientAccountAccountId",
                table: "Visits");

            migrationBuilder.DropColumn(
                name: "CallsToActionsCode",
                table: "PtdScores");

            migrationBuilder.DropColumn(
                name: "PatientAccountAccountId",
                table: "PtdScores");

            migrationBuilder.DropColumn(
                name: "PatientAccountAccountId",
                table: "NextOfKins");

            migrationBuilder.DropColumn(
                name: "PatientAccountAccountId",
                table: "Guarantors");
        }
    }
}
