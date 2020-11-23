using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalData.Migrations
{
    public partial class fourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BillingProviders",
                columns: table => new
                {
                    ProviderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderCode = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    ReferenceIdQualifier = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    ReferenceID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    EntityTypeQualifier = table.Column<string>(type: "nvarchar(1)", nullable: true),
                    NameLast = table.Column<string>(type: "nvarchar(60)", nullable: true),
                    NameFirst = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    NameMiddle = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    NamePrefix = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    NameSuffix = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    IdentificationCodeQualifier = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    IdentificationCode = table.Column<string>(type: "nvarchar(80)", nullable: true),
                    Addres = table.Column<string>(type: "nvarchar(80)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    TaxReferenceIdQualifier = table.Column<string>(type: "nvarchar(3)", nullable: true),
                    TaxReferenceId = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingProviders", x => x.ProviderId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillingProviders");
        }
    }
}
