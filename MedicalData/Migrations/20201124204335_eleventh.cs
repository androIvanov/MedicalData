using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalData.Migrations
{
    public partial class eleventh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    ProviderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimId = table.Column<int>(type: "int", nullable: false),
                    EntityIdCode = table.Column<string>(type: "nchar(2)", nullable: false),
                    EntityTypeQualifier = table.Column<string>(type: "nchar(1)", nullable: false),
                    NameLast = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    NameFirst = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    NameMidle = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    NamePrefix = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    NameSuffix = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    IdCodeQualifier = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    IdCode = table.Column<string>(type: "nvarchar(80)", nullable: true),
                    EmployersIdentificationNumber = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(80)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.ProviderId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Providers");
        }
    }
}
