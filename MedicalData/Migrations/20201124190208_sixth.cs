using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalData.Migrations
{
    public partial class sixth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NextOfKins",
                columns: table => new
                {
                    NOKId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    SetID = table.Column<string>(type: "nchar(255)", nullable: false),
                    Name = table.Column<string>(type: "nchar(255)", nullable: false),
                    Relationship = table.Column<string>(type: "nchar(255)", nullable: false),
                    Address = table.Column<string>(type: "nchar(255)", nullable: false),
                    PhoneHome = table.Column<string>(type: "nchar(255)", nullable: false),
                    PhoneBusiness = table.Column<string>(type: "nchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NextOfKins", x => x.NOKId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NextOfKins");
        }
    }
}
