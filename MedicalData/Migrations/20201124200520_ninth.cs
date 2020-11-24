using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalData.Migrations
{
    public partial class ninth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientIdExt = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    MRN = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PatientId = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    FamilyName = table.Column<string>(type: "nchar(255)", nullable: false),
                    GivenName = table.Column<string>(type: "nchar(255)", nullable: false),
                    MiddleName = table.Column<string>(type: "nchar(255)", nullable: false),
                    NameSuffix = table.Column<string>(type: "nchar(255)", nullable: false),
                    MothersMaidenName = table.Column<string>(type: "nchar(255)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    Sex = table.Column<string>(type: "varchar(1)", nullable: false),
                    Race = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    StreetAddress = table.Column<string>(type: "nchar(255)", nullable: false),
                    OtherDesignation = table.Column<string>(type: "nchar(255)", nullable: false),
                    City = table.Column<string>(type: "nchar(10)", nullable: false),
                    State = table.Column<string>(type: "nchar(10)", nullable: false),
                    Zip = table.Column<string>(type: "nchar(10)", nullable: false),
                    Country = table.Column<string>(type: "nchar(10)", nullable: true),
                    PhoneHome = table.Column<string>(type: "nchar(10)", nullable: true),
                    PhoneBusiness = table.Column<string>(type: "nchar(10)", nullable: true),
                    Language = table.Column<string>(type: "nchar(10)", nullable: true),
                    SNN = table.Column<string>(type: "nchar(10)", nullable: false),
                    DriversLicense = table.Column<string>(type: "nchar(10)", nullable: true),
                    MultipleBirthIndicator = table.Column<bool>(type: "bit", nullable: false),
                    BirthOrder = table.Column<int>(type: "int", nullable: false),
                    Citizenship = table.Column<string>(type: "nchar(10)", nullable: true),
                    PatientDeathDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    PatientDeathIndicator = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
