using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalData.Migrations
{
    public partial class first : Migration
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

            migrationBuilder.CreateTable(
                name: "Claims",
                columns: table => new
                {
                    ClaimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    PatientControlNumber = table.Column<string>(type: "nvarchar(38)", nullable: false),
                    MonetaryAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FacilityCodeValue = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    FacilityCodeQualifier = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    ClaimFrequencyTypeCode = table.Column<string>(type: "nchar(1)", nullable: false),
                    SignatureOnFileIndicator = table.Column<string>(type: "nchar(1)", nullable: true),
                    ProviderAcceptAssignmentCode = table.Column<string>(type: "nchar(1)", nullable: true),
                    AssignmentOfBenefitsIndicator = table.Column<string>(type: "nchar(1)", nullable: true),
                    RelatedCausesCode = table.Column<string>(type: "nvarchar(3)", nullable: true),
                    OnsetDate = table.Column<DateTime>(type: "date", nullable: false),
                    DTP434 = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    PrincipalDiagnosisCode = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    AdditionalDiagnosisCode1 = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    AdditionalDiagnosisCode2 = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    OccurrenceCode = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    OccurenceDate = table.Column<DateTime>(type: "date", nullable: false),
                    InstitutionalAdmissionTypeCode = table.Column<string>(type: "nchar(1)", nullable: true),
                    InstitutionalAdmissionSourceCode = table.Column<string>(type: "nchar(1)", nullable: true),
                    InstitutionalInstitutionalPatientStatusCode = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    ClaimRefferenceId = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claims", x => x.ClaimId);
                });

            migrationBuilder.CreateTable(
                name: "Diagnosis",
                columns: table => new
                {
                    DiagnosisId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SetID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DiagnosisCodingMethod = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    DiagnosisCode = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DiagnosisDescription = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    DiagnosisDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    DiagnosisType = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    DiagnosticRelatedGroup = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnosis", x => x.DiagnosisId);
                });

            migrationBuilder.CreateTable(
                name: "EDI835Messages",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EDI835Messages", x => x.MessageId);
                });

            migrationBuilder.CreateTable(
                name: "EDI837Message",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EDI837Message", x => x.MessageId);
                });

            migrationBuilder.CreateTable(
                name: "Eligibility",
                columns: table => new
                {
                    EligibilityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsuranceId = table.Column<int>(type: "int", nullable: false),
                    SetID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    EligibilityStatus = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    COBSequence = table.Column<int>(type: "int", nullable: false),
                    SetIDZM2 = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    UnpaidBalance = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    UnpaidBalanceType = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eligibility", x => x.EligibilityId);
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

            migrationBuilder.DropTable(
                name: "Claims");

            migrationBuilder.DropTable(
                name: "Diagnosis");

            migrationBuilder.DropTable(
                name: "EDI835Messages");

            migrationBuilder.DropTable(
                name: "EDI837Message");

            migrationBuilder.DropTable(
                name: "Eligibility");
        }
    }
}
