using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalData.Migrations
{
    public partial class firstRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_PatientAccounts_PersonId",
                table: "PatientAccounts",
                column: "PersonId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAccounts_Persons_PersonId",
                table: "PatientAccounts",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientAccounts_Persons_PersonId",
                table: "PatientAccounts");

            migrationBuilder.DropIndex(
                name: "IX_PatientAccounts_PersonId",
                table: "PatientAccounts");
        }
    }
}
