using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalData.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Guarantors",
                columns: table => new
                {
                    GuarantorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    FamilyName = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    GivenName = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Suffix = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    SetID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Zip = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    PhoneNumberHome = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PhoneNumberBusiness = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    Relationship = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    SNN = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    EmployerName = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    EmployerAddress = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    EmployerPhoneNumber = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guarantors", x => x.GuarantorId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Guarantors");
        }
    }
}
