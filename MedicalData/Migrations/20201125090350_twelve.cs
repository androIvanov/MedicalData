using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalData.Migrations
{
    public partial class twelve : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ServiceLines",
                columns: table => new
                {
                    ServiceLineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimId = table.Column<int>(type: "int", nullable: false),
                    ServiceIDQualifier = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    ServiceID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ProcedureModifier = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    MonetaryAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitForMeasurementCode = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(8,3)", nullable: false),
                    FacilityCode = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    ServiceTypeCode = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    PrimaryDiagnosisCodePointer = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    SecondaryDiagnosisCodePointer = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    ServiceDateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceLines", x => x.ServiceLineId);
                });

            migrationBuilder.CreateTable(
                name: "ServicePayments",
                columns: table => new
                {
                    ServicePaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimPaymentId = table.Column<int>(type: "int", nullable: false),
                    ServiceIdQualifier = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    AdjudicatedProcedureCode = table.Column<string>(type: "nvarchar(48)", nullable: false),
                    ProcedureModifier = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    LineItemChargeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LineItemProviderPaymentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NUBCRevenueCode = table.Column<string>(type: "nvarchar(48)", nullable: true),
                    UnitsOfServicePaidCount = table.Column<int>(type: "int", nullable: false),
                    MedicalProcedureIdQualifier = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    MedicalProcedureCode = table.Column<string>(type: "nvarchar(48)", nullable: true),
                    MedicalProcedureModifier = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    ServiceDate = table.Column<DateTime>(type: "date", nullable: false),
                    ClaimAdjustmentGroupCode = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    AdjustmentReasonCode = table.Column<string>(type: "nvarchar(5)", nullable: true),
                    AdjustmentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AdjustmentQuantity = table.Column<int>(type: "int", nullable: false),
                    LineItemControlNumber = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ServiceSupplementalAmountQualifierCode = table.Column<string>(type: "nvarchar(3)", nullable: true),
                    ServiceSupplementalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicePayments", x => x.ServicePaymentId);
                });

            migrationBuilder.CreateTable(
                name: "Subscribers",
                columns: table => new
                {
                    SubscriberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    MessageId = table.Column<int>(type: "int", nullable: false),
                    PayerResponsibilitySequenceNumberCode = table.Column<string>(type: "nchar(1)", nullable: false),
                    IndividualRelationshipCode = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    ReferenceIdentification = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(60)", nullable: true),
                    InsuranceTypeCode = table.Column<string>(type: "nvarchar(3)", nullable: true),
                    ClaimFilingIndicatorCode = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    SubscriberEntityTypeQualifier = table.Column<string>(type: "nchar(1)", nullable: true),
                    SubscriberNameLast = table.Column<string>(type: "nvarchar(60)", nullable: true),
                    SubscriberNameFirst = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    SubscriberNameMidle = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    SubscriberNamePrefix = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    SubscriberNameSuffix = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    SubscriberIdentificationCodeQualifier = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    SubscriberIdentificationCode = table.Column<string>(type: "nvarchar(80)", nullable: true),
                    SubscriberAddress = table.Column<string>(type: "nvarchar(80)", nullable: true),
                    SubscriberCity = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    SubscriberState = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    SubscriberZip = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    SubscriberDateOfBirth = table.Column<DateTime>(type: "datetime", nullable: false),
                    SubscriberSex = table.Column<string>(type: "nvarchar(1)", nullable: true),
                    PayerEntityTypeQualifier = table.Column<string>(type: "nvarchar(1)", nullable: true),
                    PayerNameLast = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PayerNameFirst = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PayerNameMidle = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PayerNamePrefix = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    PayerNameSuffix = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    PayerIdentificationCodeQualifier = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    PayerIdentificationCode = table.Column<string>(type: "nvarchar(80)", nullable: true),
                    PayerAddress = table.Column<string>(type: "nvarchar(80)", nullable: true),
                    PayerCity = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PayerState = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    PayerZip = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscribers", x => x.SubscriberId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropTable(
                name: "ServiceLines");

            migrationBuilder.DropTable(
                name: "ServicePayments");

            migrationBuilder.DropTable(
                name: "Subscribers");
        }
    }
}
