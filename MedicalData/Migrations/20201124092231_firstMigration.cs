using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalData.Migrations
{
    public partial class firstMigration : Migration
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

            migrationBuilder.CreateTable(
                name: "CallsToActions",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Action1 = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Action2 = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    PtdCoeficient = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CallsToActions", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "ClaimPayments",
                columns: table => new
                {
                    ClaimPaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionId = table.Column<int>(type: "int", nullable: false),
                    MessageId = table.Column<int>(type: "int", nullable: false),
                    PatientControlNumber = table.Column<string>(type: "nvarchar(38)", nullable: false),
                    ClaimStatusCode = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    TotalClaimChargeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ClaimPaymentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PatientResponsibilityAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ClaimFilingIndicatorCode = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    PayerClaimControlNumber = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    FacilityCodeValue = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    ClaimFrequencyTypeCode = table.Column<string>(type: "nchar(1)", nullable: true),
                    PatientEntityTypeQualifier = table.Column<string>(type: "nchar(1)", nullable: false),
                    PatientLastName = table.Column<string>(type: "nvarchar(60)", nullable: true),
                    PatientFirstName = table.Column<string>(type: "nvarchar(35)", nullable: true),
                    PatientMiddleName = table.Column<string>(type: "nvarchar(25)", nullable: true),
                    SubscriberEntiryTypeQualifier = table.Column<string>(type: "nvarchar(1)", nullable: true),
                    SubscriberLastName = table.Column<string>(type: "nvarchar(60)", nullable: true),
                    SubscriberFirstName = table.Column<string>(type: "nvarchar(35)", nullable: true),
                    SubscriberMiddleName = table.Column<string>(type: "nvarchar(25)", nullable: true),
                    SubscribreNameSuffix = table.Column<string>(type: "nvarchar(25)", nullable: true),
                    SubscriberIdCodeQualifier = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    SubscriberIdentifierCode = table.Column<string>(type: "nvarchar(80)", nullable: true),
                    CorrectedSubscriberEntiryTypeQualifier = table.Column<string>(type: "nvarchar(1)", nullable: true),
                    CorrectedSubscriberLastName = table.Column<string>(type: "nvarchar(60)", nullable: true),
                    CorrectedSubscriberFirstName = table.Column<string>(type: "nvarchar(35)", nullable: true),
                    CorrectedSubscriberMiddleName = table.Column<string>(type: "nvarchar(25)", nullable: true),
                    CorrectedSubscribreNameSuffix = table.Column<string>(type: "nchar(10)", nullable: true),
                    RenderingProviderEntityTypeQualifier = table.Column<string>(type: "nvarchar(1)", nullable: true),
                    RenderingProviderLastName = table.Column<string>(type: "nvarchar(60)", nullable: true),
                    RenderingProviderFirstName = table.Column<string>(type: "nvarchar(35)", nullable: true),
                    RenderingProviderMiddleName = table.Column<string>(type: "nvarchar(25)", nullable: true),
                    RenderingProviderNameSuffix = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    RenderingProviderIdCodeQualifier = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    RenderingProviderId = table.Column<string>(type: "nvarchar(80)", nullable: true),
                    ClaimRecivedDate = table.Column<DateTime>(type: "date", nullable: false),
                    ClaimPaymentPeriodStartDate = table.Column<DateTime>(type: "date", nullable: false),
                    ClaimPaymentPeriodEndDate = table.Column<DateTime>(type: "date", nullable: false),
                    ClaimContactComunicationsNumberQualifier = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    ClaimContactComunicationsNumber = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    CoverageAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClaimPayments", x => x.ClaimPaymentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillingProviders");

            migrationBuilder.DropTable(
                name: "CallsToActions");

            migrationBuilder.DropTable(
                name: "ClaimPayments");
        }
    }
}
