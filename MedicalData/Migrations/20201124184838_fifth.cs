using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalData.Migrations
{
    public partial class fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LineNumbers",
                columns: table => new
                {
                    LineNumberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionId = table.Column<int>(type: "int", nullable: false),
                    ProviderId = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    FacilityTypeCode = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    FiscalPeriodDate = table.Column<DateTime>(type: "date", nullable: false),
                    TotalClaimCount = table.Column<int>(type: "int", nullable: false),
                    TotalClaimChargeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineNumbers", x => x.LineNumberId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LineNumbers");
        }
    }
}
