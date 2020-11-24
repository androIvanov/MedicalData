using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalData.Migrations
{
    public partial class tenth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Procedures",
                columns: table => new
                {
                    ProcedureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiagnosisId = table.Column<int>(type: "int", nullable: false),
                    SerID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ProcedureCodingMethod = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ProcedureCode = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ProcedureDescription = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    ProcedureDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    AssociatedDiagnosis = table.Column<string>(type: "nvarchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedures", x => x.ProcedureId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Procedures");
        }
    }
}
