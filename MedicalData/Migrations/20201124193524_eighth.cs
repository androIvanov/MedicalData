using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalData.Migrations
{
    public partial class eighth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    EntityTypeQualifier = table.Column<string>(type: "nchar(1)", nullable: true),
                    NameLast = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    NameFirst = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    NameMidle = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    NamePrefix = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    NameSuffix = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    Sex = table.Column<string>(type: "nchar(1)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(80)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    ZIp = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    IndividualRelationshipCode = table.Column<string>(type: "nvarchar(2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
