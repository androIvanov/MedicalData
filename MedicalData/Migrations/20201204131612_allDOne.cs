using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalData.Migrations
{
    public partial class allDOne : Migration
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
                    DateAdded = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EDI837Message", x => x.MessageId);
                });

            migrationBuilder.CreateTable(
                name: "HL7Messages",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageDateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

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
                    PatientDeathDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PatientDeathIndicator = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionHandlingCode = table.Column<string>(type: "varchar(2)", nullable: false),
                    TotalActualProviderPaymentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreditDebitFlag = table.Column<string>(type: "nchar(1)", nullable: false),
                    PaymentMethodCode = table.Column<string>(type: "nchar(3)", nullable: false),
                    PaymentFormatCode = table.Column<string>(type: "varchar(10)", nullable: true),
                    DFIIdNumberQualifier_BPR06 = table.Column<string>(type: "nchar(2)", nullable: true),
                    SenderDFIIdentifier = table.Column<string>(type: "varchar(12)", nullable: true),
                    AccountNumberQualifier_BPR08 = table.Column<string>(type: "varchar(3)", nullable: true),
                    SenderBankAccountNumber = table.Column<string>(type: "varchar(35)", nullable: true),
                    PayerId_BPR10 = table.Column<string>(type: "varchar(10)", nullable: true),
                    OriginatingCompanySupplementalCode_BPR11 = table.Column<string>(type: "varchar(10)", nullable: true),
                    DFIIdNumberQualifier_BPR12 = table.Column<string>(type: "nchar(2)", nullable: true),
                    ReceiverOrProviderBankIDNumber = table.Column<string>(type: "varchar(12)", nullable: true),
                    AccountNumberQualifier_BPR14 = table.Column<string>(type: "varchar(3)", nullable: true),
                    ReceiverOrProviderAccountNumber = table.Column<string>(type: "varchar(35)", nullable: true),
                    CheckIssueOrEFTEffectiveDate = table.Column<DateTime>(type: "date", nullable: false),
                    EFTTraceNumber = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ReceiverId_REF_EV = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ProductionDate_REF_405 = table.Column<DateTime>(type: "date", nullable: false),
                    PayerName = table.Column<string>(type: "nvarchar(60)", nullable: true),
                    PayerIdentifier_N104 = table.Column<string>(type: "nvarchar(80)", nullable: true),
                    PayerAddress = table.Column<string>(type: "nvarchar(80)", nullable: true),
                    PayerCity = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PayerState = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    PayerZip = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    ReferenceIdQualifier_REF_2U = table.Column<string>(type: "nvarchar(3)", nullable: true),
                    AdditionalPayerId_REF_2U = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PayerContactName = table.Column<string>(type: "nvarchar(60)", nullable: true),
                    CommunicationNumberQualifier_PER_CX = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    CommunicationNumber_PER_CX = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    PayeeName = table.Column<string>(type: "nvarchar(60)", nullable: false),
                    PayeeIdCodeQualifier = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    PayeeIdCode = table.Column<string>(type: "nvarchar(80)", nullable: true),
                    PayeeAddress = table.Column<string>(type: "nvarchar(80)", nullable: true),
                    PayeeCity = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PayeeState = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    PayeeZip = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    PayeeReferenceIdQualifier_REF_PQ = table.Column<string>(type: "nvarchar(3)", nullable: true),
                    AdditionalPayeeId_REF_PQ = table.Column<string>(type: "nvarchar(80)", nullable: true),
                    PayeeReferenceIdQualifier_REF_TJ = table.Column<string>(type: "nvarchar(3)", nullable: true),
                    AdditionalPayeeId_REF_TJ = table.Column<string>(type: "nvarchar(80)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionId);
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
                    SubscriberDateOfBirth = table.Column<DateTime>(type: "datetime", nullable: true),
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
                    PayerZip = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    EDI837MessageMessageId = table.Column<int>(type: "int", nullable: true),
                    BillingProviderProviderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscribers", x => x.SubscriberId);
                    table.ForeignKey(
                        name: "FK_Subscribers_BillingProviders_BillingProviderProviderId",
                        column: x => x.BillingProviderProviderId,
                        principalTable: "BillingProviders",
                        principalColumn: "ProviderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Subscribers_EDI837Message_EDI837MessageMessageId",
                        column: x => x.EDI837MessageMessageId,
                        principalTable: "EDI837Message",
                        principalColumn: "MessageId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatientAccounts",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    AppointmentID = table.Column<string>(type: "nchar(10)", nullable: true),
                    PatientAccountNumber = table.Column<string>(type: "nchar(255)", nullable: false),
                    PrimaryCareProvider = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    StudentIndicator = table.Column<bool>(type: "bit", nullable: false),
                    Facility = table.Column<string>(type: "nvarchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientAccounts", x => x.AccountId);
                    table.ForeignKey(
                        name: "FK_PatientAccounts_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    CoverageAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EDI835MessageMessageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClaimPayments", x => x.ClaimPaymentId);
                    table.ForeignKey(
                        name: "FK_ClaimPayments_EDI835Messages_EDI835MessageMessageId",
                        column: x => x.EDI835MessageMessageId,
                        principalTable: "EDI835Messages",
                        principalColumn: "MessageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClaimPayments_Transactions_TransactionId",
                        column: x => x.TransactionId,
                        principalTable: "Transactions",
                        principalColumn: "TransactionId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    table.ForeignKey(
                        name: "FK_LineNumbers_Transactions_TransactionId",
                        column: x => x.TransactionId,
                        principalTable: "Transactions",
                        principalColumn: "TransactionId",
                        onDelete: ReferentialAction.Cascade);
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
                    OnsetDate = table.Column<DateTime>(type: "date", nullable: true),
                    DTP434 = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    PrincipalDiagnosisCode = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    AdditionalDiagnosisCode1 = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    AdditionalDiagnosisCode2 = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    OccurrenceCode = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    OccurenceDate = table.Column<DateTime>(type: "date", nullable: true),
                    InstitutionalAdmissionTypeCode = table.Column<string>(type: "nchar(1)", nullable: true),
                    InstitutionalAdmissionSourceCode = table.Column<string>(type: "nchar(1)", nullable: true),
                    InstitutionalInstitutionalPatientStatusCode = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    ClaimRefferenceId = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claims", x => x.ClaimId);
                    table.ForeignKey(
                        name: "FK_Claims_Subscribers_SubscriberId",
                        column: x => x.SubscriberId,
                        principalTable: "Subscribers",
                        principalColumn: "SubscriberId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    table.ForeignKey(
                        name: "FK_Patients_Subscribers_SubscriberId",
                        column: x => x.SubscriberId,
                        principalTable: "Subscribers",
                        principalColumn: "SubscriberId",
                        onDelete: ReferentialAction.Cascade);
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
                    DiagnosisDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    DiagnosisType = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    DiagnosticRelatedGroup = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    PatientAccountAccountId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnosis", x => x.DiagnosisId);
                    table.ForeignKey(
                        name: "FK_Diagnosis_PatientAccounts_PatientAccountAccountId",
                        column: x => x.PatientAccountAccountId,
                        principalTable: "PatientAccounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                });

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
                    EmployerPhoneNumber = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PatientAccountAccountId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guarantors", x => x.GuarantorId);
                    table.ForeignKey(
                        name: "FK_Guarantors_PatientAccounts_PatientAccountAccountId",
                        column: x => x.PatientAccountAccountId,
                        principalTable: "PatientAccounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                });

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
                    PhoneBusiness = table.Column<string>(type: "nchar(255)", nullable: false),
                    PatientAccountAccountId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NextOfKins", x => x.NOKId);
                    table.ForeignKey(
                        name: "FK_NextOfKins_PatientAccounts_PatientAccountAccountId",
                        column: x => x.PatientAccountAccountId,
                        principalTable: "PatientAccounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PtdScores",
                columns: table => new
                {
                    ScoreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Score = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsResolved = table.Column<bool>(type: "bit", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ResolvedBy = table.Column<string>(type: "nchar(10)", nullable: true),
                    ResolvedDate = table.Column<DateTime>(type: "date", nullable: true),
                    PatientAccountAccountId = table.Column<int>(type: "int", nullable: true),
                    CallsToActionsCode = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PtdScores", x => x.ScoreId);
                    table.ForeignKey(
                        name: "FK_PtdScores_CallsToActions_CallsToActionsCode",
                        column: x => x.CallsToActionsCode,
                        principalTable: "CallsToActions",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PtdScores_PatientAccounts_PatientAccountAccountId",
                        column: x => x.PatientAccountAccountId,
                        principalTable: "PatientAccounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Visits",
                columns: table => new
                {
                    VisitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SetID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PatientClass = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    AssignedLocation = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    AdmissionType = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PreAdmitNumber = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PriorLocation = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    AttendingDoctorID = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    AttendingDoctorFamilyName = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    AttendingDoctorGivenName = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    AttendingDoctorMiddleName = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    AttendingDoctorSuffix = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    AttendingDoctorPrefix = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    ReferringDoctor = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    ConsultingDoctor = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    HospitalService = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    TemporaryLocation = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    PreAdmitTestIndicator = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ReadmissionIndicator = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    AdmitSource = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    AmbulatoryStatus = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    VipIndicator = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    AdmittingDoctorID = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    AdmittingDoctorFamilyName = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    AdmittingDoctorGivenName = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    AdmittingDoctorMiddleName = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    AdmittingDoctorSuffix = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    AdmittingDoctorPrefix = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    PatientType = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    VisitNumber = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    FinancialClass = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CourtesyCode = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ContractCode = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ContractEffectiveDate = table.Column<DateTime>(type: "date", nullable: false),
                    ContractAmount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    ContractPeriod = table.Column<int>(type: "int", nullable: false),
                    InterestCode = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    DeleteAccountIndicator = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DeleteAccountDate = table.Column<DateTime>(type: "date", nullable: false),
                    DischargeDisposition = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    DischargeToLocation = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ServicingFacility = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    BedStatus = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    AccountStatus = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PendingLocation = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PriorTemporaryLocation = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    AdmitDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    DischargeDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    CurrentPatientBalance = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    TotalCharges = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    TotalAdjustments = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    TotalPayments = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    AlternateVisitID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    VisitIndicator = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    AccommodationCode = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    AdmitReason = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    TransferReason = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ExpectedAdmitDate = table.Column<DateTime>(type: "date", nullable: false),
                    ExpectedDischargeDate = table.Column<DateTime>(type: "date", nullable: false),
                    EstimatedLengthOfIPstay = table.Column<int>(type: "int", nullable: false),
                    ActualLengthOfIPStay = table.Column<int>(type: "int", nullable: false),
                    VisitDescription = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ReferralSourceCode = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PatientStatusCode = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PatientAccountAccountId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visits", x => x.VisitId);
                    table.ForeignKey(
                        name: "FK_Visits_PatientAccounts_PatientAccountAccountId",
                        column: x => x.PatientAccountAccountId,
                        principalTable: "PatientAccounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
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
                    table.ForeignKey(
                        name: "FK_ServicePayments_ClaimPayments_ClaimPaymentId",
                        column: x => x.ClaimPaymentId,
                        principalTable: "ClaimPayments",
                        principalColumn: "ClaimPaymentId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    table.ForeignKey(
                        name: "FK_Providers_Claims_ClaimId",
                        column: x => x.ClaimId,
                        principalTable: "Claims",
                        principalColumn: "ClaimId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    ServiceDateTime = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceLines", x => x.ServiceLineId);
                    table.ForeignKey(
                        name: "FK_ServiceLines_Claims_ClaimId",
                        column: x => x.ClaimId,
                        principalTable: "Claims",
                        principalColumn: "ClaimId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Procedures",
                columns: table => new
                {
                    ProcedureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiagnosisId = table.Column<int>(type: "int", nullable: false),
                    SerID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ProcedureCodingMethod = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ProcedureCode = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ProcedureDescription = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    ProcedureDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    AssociatedDiagnosis = table.Column<string>(type: "nvarchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedures", x => x.ProcedureId);
                    table.ForeignKey(
                        name: "FK_Procedures_Diagnosis_DiagnosisId",
                        column: x => x.DiagnosisId,
                        principalTable: "Diagnosis",
                        principalColumn: "DiagnosisId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Insurances",
                columns: table => new
                {
                    InsuranceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuarantorId = table.Column<int>(type: "int", nullable: false),
                    SetID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PlanCode = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CompanyID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    CompanyAddress = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    CompanyPhoneNumber = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    GroupNumber = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    GroupName = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    PlanEffectiveDate = table.Column<DateTime>(type: "date", nullable: false),
                    PlanExpirationDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    AuthorizationInformation = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    PlanType = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    InsuredFamilyName = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    InsuredGivenName = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    InsuredMiddleName = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    InsuredSuffix = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    RelationshiptoPatient = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    InsuredsDateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    InsuredsAddress = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    CoordinationofBenefits = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CoordinationBenefitsPriority = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    NoticeofAdmissionCode = table.Column<byte[]>(type: "varbinary(50)", nullable: false),
                    NoticeofAdmissionDate = table.Column<DateTime>(type: "date", nullable: false),
                    ReportofEligibilityCode = table.Column<byte[]>(type: "varbinary(50)", nullable: false),
                    ReportofEligibilityDate = table.Column<DateTime>(type: "date", nullable: false),
                    PreAdmitCertification = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    VerificationDateTime = table.Column<DateTime>(type: "date", nullable: false),
                    VerificationBy = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    BillingStatus = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CompanyPlanCode = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PolicyNumber = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    VerificationStatus = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PriorInsurancePlanID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    InsuredsIDNumber = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    SetIDIN2 = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    InsuredsSSN = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    InsuredsEmployerName = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    SetIDIN3 = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CertificationNumber = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CertifiedBy = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CertificationRequired = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CertificationDateTime = table.Column<DateTime>(type: "date", nullable: false),
                    CertificationModifyDateTime = table.Column<DateTime>(type: "date", nullable: false),
                    Operator = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CertificationBeginDate = table.Column<DateTime>(type: "date", nullable: false),
                    CertificationEndDate = table.Column<DateTime>(type: "date", nullable: false),
                    Days = table.Column<int>(type: "int", nullable: false),
                    CertificationAgency = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    PreCertificationReqWindow = table.Column<string>(type: "nvarchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurances", x => x.InsuranceId);
                    table.ForeignKey(
                        name: "FK_Insurances_Guarantors_GuarantorId",
                        column: x => x.GuarantorId,
                        principalTable: "Guarantors",
                        principalColumn: "GuarantorId",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_Eligibility_Insurances_InsuranceId",
                        column: x => x.InsuranceId,
                        principalTable: "Insurances",
                        principalColumn: "InsuranceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BillingProviders",
                columns: new[] { "ProviderId", "Addres", "City", "EntityTypeQualifier", "IdentificationCode", "IdentificationCodeQualifier", "NameFirst", "NameLast", "NameMiddle", "NamePrefix", "NameSuffix", "ProviderCode", "ReferenceID", "ReferenceIdQualifier", "State", "TaxReferenceId", "TaxReferenceIdQualifier", "Zip" },
                values: new object[] { 1, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "CallsToActions",
                columns: new[] { "Code", "Action1", "Action2", "PtdCoeficient" },
                values: new object[] { "74589OTKJFN", "Diagnose", "Procedures", 256 });

            migrationBuilder.InsertData(
                table: "Diagnosis",
                columns: new[] { "DiagnosisId", "AccountId", "DiagnosisCode", "DiagnosisCodingMethod", "DiagnosisDateTime", "DiagnosisDescription", "DiagnosisType", "DiagnosticRelatedGroup", "PatientAccountAccountId", "SetID" },
                values: new object[] { 1, 1, "ITSOK00", null, null, "ALLGOOD", null, "Elders", null, "Identity" });

            migrationBuilder.InsertData(
                table: "EDI835Messages",
                columns: new[] { "MessageId", "DateAdded", "Message" },
                values: new object[] { 1, new DateTime(2020, 12, 4, 13, 16, 11, 342, DateTimeKind.Utc).AddTicks(317), "Lorem ipsum ziben aleb" });

            migrationBuilder.InsertData(
                table: "EDI837Message",
                columns: new[] { "MessageId", "DateAdded", "Message" },
                values: new object[] { 1, new DateTime(2020, 12, 4, 13, 16, 11, 350, DateTimeKind.Utc).AddTicks(5265), "All good" });

            migrationBuilder.InsertData(
                table: "Guarantors",
                columns: new[] { "GuarantorId", "AccountId", "City", "DateOfBirth", "EmployerAddress", "EmployerName", "EmployerPhoneNumber", "FamilyName", "GivenName", "MiddleName", "PatientAccountAccountId", "PhoneNumberBusiness", "PhoneNumberHome", "Relationship", "SNN", "SetID", "State", "StreetAddress", "Suffix", "Zip" },
                values: new object[] { 1, 1, "Sofia", new DateTime(2020, 12, 4, 13, 16, 11, 345, DateTimeKind.Utc).AddTicks(6732), null, null, null, "Ivanov", "Stoqn", "Jack", null, null, null, null, null, "545NM349Y46", "Sofia", "Vihren40", "ly", "1701" });

            migrationBuilder.InsertData(
                table: "NextOfKins",
                columns: new[] { "NOKId", "AccountId", "Address", "Name", "PatientAccountAccountId", "PhoneBusiness", "PhoneHome", "Relationship", "SetID" },
                values: new object[] { 1, 1, "Sofia, Vihren 40", "Jason", null, "555785", "305693", "brother", "SOMEID" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "BirthOrder", "Citizenship", "City", "Country", "DateOfBirth", "DriversLicense", "FamilyName", "GivenName", "Language", "MRN", "MiddleName", "MothersMaidenName", "MultipleBirthIndicator", "NameSuffix", "OtherDesignation", "PatientDeathDate", "PatientDeathIndicator", "PatientId", "PatientIdExt", "PhoneBusiness", "PhoneHome", "Race", "SNN", "Sex", "State", "StreetAddress", "Zip" },
                values: new object[] { 1, 0, null, "Varna", null, new DateTime(2020, 12, 4, 13, 16, 11, 344, DateTimeKind.Utc).AddTicks(2650), null, "Silvester", "Jo", null, "SERVICE", "Jackson", "Marine", false, "ly", "Eastern BG", null, null, "GOSHOPECHEV225", "SURENDERAT20", null, null, null, "YO", "M", "VarnaState", "Osmi PRimorski polk", "9010" });

            migrationBuilder.InsertData(
                table: "PtdScores",
                columns: new[] { "ScoreId", "AccountId", "CallsToActionsCode", "Code", "IsResolved", "Notes", "PatientAccountAccountId", "ResolvedBy", "ResolvedDate", "Score" },
                values: new object[] { 1, 1, null, "50GNFH78G", true, null, null, null, null, 25.7m });

            migrationBuilder.InsertData(
                table: "Subscribers",
                columns: new[] { "SubscriberId", "BillingProviderProviderId", "ClaimFilingIndicatorCode", "EDI837MessageMessageId", "IndividualRelationshipCode", "InsuranceTypeCode", "MessageId", "Name", "PayerAddress", "PayerCity", "PayerEntityTypeQualifier", "PayerIdentificationCode", "PayerIdentificationCodeQualifier", "PayerNameFirst", "PayerNameLast", "PayerNameMidle", "PayerNamePrefix", "PayerNameSuffix", "PayerResponsibilitySequenceNumberCode", "PayerState", "PayerZip", "ProviderId", "ReferenceIdentification", "SubscriberAddress", "SubscriberCity", "SubscriberDateOfBirth", "SubscriberEntityTypeQualifier", "SubscriberIdentificationCode", "SubscriberIdentificationCodeQualifier", "SubscriberNameFirst", "SubscriberNameLast", "SubscriberNameMidle", "SubscriberNamePrefix", "SubscriberNameSuffix", "SubscriberSex", "SubscriberState", "SubscriberZip" },
                values: new object[] { 1, null, null, null, null, null, 1, null, null, null, null, null, null, null, null, null, null, null, "S", null, null, 1, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "AccountNumberQualifier_BPR08", "AccountNumberQualifier_BPR14", "AdditionalPayeeId_REF_PQ", "AdditionalPayeeId_REF_TJ", "AdditionalPayerId_REF_2U", "CheckIssueOrEFTEffectiveDate", "CommunicationNumberQualifier_PER_CX", "CommunicationNumber_PER_CX", "CreditDebitFlag", "DFIIdNumberQualifier_BPR06", "DFIIdNumberQualifier_BPR12", "EFTTraceNumber", "OriginatingCompanySupplementalCode_BPR11", "PayeeAddress", "PayeeCity", "PayeeIdCode", "PayeeIdCodeQualifier", "PayeeName", "PayeeReferenceIdQualifier_REF_PQ", "PayeeReferenceIdQualifier_REF_TJ", "PayeeState", "PayeeZip", "PayerAddress", "PayerCity", "PayerContactName", "PayerId_BPR10", "PayerIdentifier_N104", "PayerName", "PayerState", "PayerZip", "PaymentFormatCode", "PaymentMethodCode", "ProductionDate_REF_405", "ReceiverId_REF_EV", "ReceiverOrProviderAccountNumber", "ReceiverOrProviderBankIDNumber", "ReferenceIdQualifier_REF_2U", "SenderBankAccountNumber", "SenderDFIIdentifier", "TotalActualProviderPaymentAmount", "TransactionHandlingCode" },
                values: new object[] { 1, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "C", null, null, "G457JFHG437535HU358", null, null, null, null, null, "Robert", null, null, null, null, null, null, null, null, null, null, null, null, null, "FST", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, 2999m, "NN" });

            migrationBuilder.InsertData(
                table: "Visits",
                columns: new[] { "VisitId", "AccommodationCode", "AccountId", "AccountStatus", "ActualLengthOfIPStay", "AdmissionType", "AdmitDateTime", "AdmitReason", "AdmitSource", "AdmittingDoctorFamilyName", "AdmittingDoctorGivenName", "AdmittingDoctorID", "AdmittingDoctorMiddleName", "AdmittingDoctorPrefix", "AdmittingDoctorSuffix", "AlternateVisitID", "AmbulatoryStatus", "AssignedLocation", "AttendingDoctorFamilyName", "AttendingDoctorGivenName", "AttendingDoctorID", "AttendingDoctorMiddleName", "AttendingDoctorPrefix", "AttendingDoctorSuffix", "BedStatus", "ConsultingDoctor", "ContractAmount", "ContractCode", "ContractEffectiveDate", "ContractPeriod", "CourtesyCode", "CurrentPatientBalance", "DeleteAccountDate", "DeleteAccountIndicator", "DischargeDateTime", "DischargeDisposition", "DischargeToLocation", "EstimatedLengthOfIPstay", "ExpectedAdmitDate", "ExpectedDischargeDate", "FinancialClass", "HospitalService", "InterestCode", "PatientAccountAccountId", "PatientClass", "PatientStatusCode", "PatientType", "PendingLocation", "PreAdmitNumber", "PreAdmitTestIndicator", "PriorLocation", "PriorTemporaryLocation", "ReadmissionIndicator", "ReferralSourceCode", "ReferringDoctor", "ServicingFacility", "SetID", "TemporaryLocation", "TotalAdjustments", "TotalCharges", "TotalPayments", "TransferReason", "VipIndicator", "VisitDescription", "VisitIndicator", "VisitNumber" },
                values: new object[] { 1, null, 1, "Innactive", 0, null, new DateTime(2020, 12, 4, 13, 16, 11, 343, DateTimeKind.Utc).AddTicks(7120), null, null, "Gregor", "Jo", "U57839", "Marchal", "Juniour", "ny", null, null, "Varna", "Joshua", "Spark", "G589TY8ORIO4590", "Jonson", "Dr.", "ly", null, "Vladimir", 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 0m, new DateTime(2020, 12, 4, 13, 16, 11, 343, DateTimeKind.Utc).AddTicks(6270), "NO", new DateTime(2020, 12, 4, 13, 16, 11, 343, DateTimeKind.Utc).AddTicks(7552), null, null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Upper", "Stavri", null, null, "First", null, "Elder", null, null, null, null, null, null, null, "Jackob", null, "SETTINGID45678", null, 0m, 0m, 0m, null, null, null, null, "25CC" });

            migrationBuilder.InsertData(
                table: "ClaimPayments",
                columns: new[] { "ClaimPaymentId", "ClaimContactComunicationsNumber", "ClaimContactComunicationsNumberQualifier", "ClaimFilingIndicatorCode", "ClaimFrequencyTypeCode", "ClaimPaymentAmount", "ClaimPaymentPeriodEndDate", "ClaimPaymentPeriodStartDate", "ClaimRecivedDate", "ClaimStatusCode", "CorrectedSubscriberEntiryTypeQualifier", "CorrectedSubscriberFirstName", "CorrectedSubscriberLastName", "CorrectedSubscriberMiddleName", "CorrectedSubscribreNameSuffix", "CoverageAmount", "EDI835MessageMessageId", "FacilityCodeValue", "MessageId", "PatientControlNumber", "PatientEntityTypeQualifier", "PatientFirstName", "PatientLastName", "PatientMiddleName", "PatientResponsibilityAmount", "PayerClaimControlNumber", "RenderingProviderEntityTypeQualifier", "RenderingProviderFirstName", "RenderingProviderId", "RenderingProviderIdCodeQualifier", "RenderingProviderLastName", "RenderingProviderMiddleName", "RenderingProviderNameSuffix", "SubscriberEntiryTypeQualifier", "SubscriberFirstName", "SubscriberIdCodeQualifier", "SubscriberIdentifierCode", "SubscriberLastName", "SubscriberMiddleName", "SubscribreNameSuffix", "TotalClaimChargeAmount", "TransactionId" },
                values: new object[] { 1, null, null, "JA", null, 999m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 4, 13, 16, 11, 341, DateTimeKind.Utc).AddTicks(3567), "PS", null, null, null, null, null, 0m, null, null, 1, "JHGE578TOH4", "S", null, null, null, 0m, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 567m, 1 });

            migrationBuilder.InsertData(
                table: "Claims",
                columns: new[] { "ClaimId", "AdditionalDiagnosisCode1", "AdditionalDiagnosisCode2", "AssignmentOfBenefitsIndicator", "ClaimFrequencyTypeCode", "ClaimRefferenceId", "DTP434", "FacilityCodeQualifier", "FacilityCodeValue", "InstitutionalAdmissionSourceCode", "InstitutionalAdmissionTypeCode", "InstitutionalInstitutionalPatientStatusCode", "MonetaryAmount", "OccurenceDate", "OccurrenceCode", "OnsetDate", "PatientControlNumber", "PrincipalDiagnosisCode", "ProviderAcceptAssignmentCode", "RelatedCausesCode", "SignatureOnFileIndicator", "SubscriberId" },
                values: new object[] { 1, null, null, null, "C", null, null, "S", "C", null, null, null, 56.8m, null, null, null, "7890OJNB", null, null, null, null, 1 });

            migrationBuilder.InsertData(
                table: "Insurances",
                columns: new[] { "InsuranceId", "AuthorizationInformation", "BillingStatus", "CertificationAgency", "CertificationBeginDate", "CertificationDateTime", "CertificationEndDate", "CertificationModifyDateTime", "CertificationNumber", "CertificationRequired", "CertifiedBy", "CompanyAddress", "CompanyID", "CompanyName", "CompanyPhoneNumber", "CompanyPlanCode", "CoordinationBenefitsPriority", "CoordinationofBenefits", "Days", "GroupName", "GroupNumber", "GuarantorId", "InsuredFamilyName", "InsuredGivenName", "InsuredMiddleName", "InsuredSuffix", "InsuredsAddress", "InsuredsDateOfBirth", "InsuredsEmployerName", "InsuredsIDNumber", "InsuredsSSN", "NoticeofAdmissionCode", "NoticeofAdmissionDate", "Operator", "PlanCode", "PlanEffectiveDate", "PlanExpirationDate", "PlanType", "PolicyNumber", "PreAdmitCertification", "PreCertificationReqWindow", "PriorInsurancePlanID", "RelationshiptoPatient", "ReportofEligibilityCode", "ReportofEligibilityDate", "SetID", "SetIDIN2", "SetIDIN3", "VerificationBy", "VerificationDateTime", "VerificationStatus" },
                values: new object[] { 1, "Authorised", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Sweden", "IK40563", "IKEA", "0555857", null, null, null, 0, "Fourlis", "225", 1, "Dobrevi", "JSON", "Varchaev", "ny", "Varna, bul Osmi Primorski Polk", new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "0YR72TL49Z5", null, new byte[] { 0 }, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "SSG", new DateTime(2020, 12, 4, 13, 16, 11, 346, DateTimeKind.Utc).AddTicks(1769), new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Good", "2456", "Certificacate", null, null, "Daenerys", new byte[] { 13 }, new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GIO6543", "8y2903rj", "GHOP04U78", "Jack Morrison", new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "LineNumbers",
                columns: new[] { "LineNumberId", "FacilityTypeCode", "FiscalPeriodDate", "ProviderId", "TotalClaimChargeAmount", "TotalClaimCount", "TransactionId" },
                values: new object[] { 10, "GA", new DateTime(2020, 12, 4, 13, 16, 11, 340, DateTimeKind.Utc).AddTicks(6276), "PROVIDER225", 2421m, 65893, 1 });

            migrationBuilder.InsertData(
                table: "PatientAccounts",
                columns: new[] { "AccountId", "AppointmentID", "Facility", "PatientAccountNumber", "PersonId", "PrimaryCareProvider", "StudentIndicator" },
                values: new object[] { 1, "SSD", "SoftServe", "J7A1R3V4A9N", 1, null, false });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "PatientId", "Address", "City", "DateOfBirth", "EntityTypeQualifier", "IndividualRelationshipCode", "NameFirst", "NameLast", "NameMidle", "NamePrefix", "NameSuffix", "Sex", "State", "SubscriberId", "ZIp" },
                values: new object[] { 1, null, null, new DateTime(2020, 12, 4, 13, 16, 11, 349, DateTimeKind.Utc).AddTicks(8859), "M", "SN", null, null, null, null, null, "M", null, 1, null });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "ProcedureId", "AssociatedDiagnosis", "DiagnosisId", "ProcedureCode", "ProcedureCodingMethod", "ProcedureDateTime", "ProcedureDescription", "SerID" },
                values: new object[] { 1, null, 1, "FGHUI96543", null, new DateTime(2020, 12, 4, 13, 16, 11, 345, DateTimeKind.Utc).AddTicks(1342), "Nothing too serious", "JFK" });

            migrationBuilder.InsertData(
                table: "Eligibility",
                columns: new[] { "EligibilityId", "COBSequence", "EligibilityStatus", "InsuranceId", "SetID", "SetIDZM2", "UnpaidBalance", "UnpaidBalanceType" },
                values: new object[] { 1, 0, null, 1, "SOMEID", "835306N", 0m, null });

            migrationBuilder.InsertData(
                table: "Providers",
                columns: new[] { "ProviderId", "Address", "City", "ClaimId", "EmployersIdentificationNumber", "EntityIdCode", "EntityTypeQualifier", "IdCode", "IdCodeQualifier", "NameFirst", "NameLast", "NameMidle", "NamePrefix", "NameSuffix", "State", "Zip" },
                values: new object[] { 1, null, null, 1, null, "MS", "F", null, null, null, null, null, null, null, null, null });

            migrationBuilder.InsertData(
                table: "ServiceLines",
                columns: new[] { "ServiceLineId", "ClaimId", "FacilityCode", "MonetaryAmount", "PrimaryDiagnosisCodePointer", "ProcedureModifier", "Quantity", "SecondaryDiagnosisCodePointer", "ServiceDateTime", "ServiceID", "ServiceIDQualifier", "ServiceTypeCode", "UnitForMeasurementCode" },
                values: new object[] { 1, 1, null, 108.2m, null, null, 3.5m, null, new DateTime(2020, 12, 4, 13, 16, 11, 350, DateTimeKind.Utc).AddTicks(9359), "ghi7654", "JS", null, "GL" });

            migrationBuilder.InsertData(
                table: "ServicePayments",
                columns: new[] { "ServicePaymentId", "AdjudicatedProcedureCode", "AdjustmentAmount", "AdjustmentQuantity", "AdjustmentReasonCode", "ClaimAdjustmentGroupCode", "ClaimPaymentId", "LineItemChargeAmount", "LineItemControlNumber", "LineItemProviderPaymentAmount", "MedicalProcedureCode", "MedicalProcedureIdQualifier", "MedicalProcedureModifier", "NUBCRevenueCode", "ProcedureModifier", "ServiceDate", "ServiceIdQualifier", "ServiceSupplementalAmount", "ServiceSupplementalAmountQualifierCode", "UnitsOfServicePaidCount" },
                values: new object[] { 1, "6F48J56N9476GJG0E5HG", 0m, 0, null, null, 1, 4354.22m, null, 34.31m, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "JS", 0m, null, 334 });

            migrationBuilder.CreateIndex(
                name: "IX_ClaimPayments_EDI835MessageMessageId",
                table: "ClaimPayments",
                column: "EDI835MessageMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_ClaimPayments_TransactionId",
                table: "ClaimPayments",
                column: "TransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_Claims_SubscriberId",
                table: "Claims",
                column: "SubscriberId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnosis_PatientAccountAccountId",
                table: "Diagnosis",
                column: "PatientAccountAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Eligibility_InsuranceId",
                table: "Eligibility",
                column: "InsuranceId");

            migrationBuilder.CreateIndex(
                name: "IX_Guarantors_PatientAccountAccountId",
                table: "Guarantors",
                column: "PatientAccountAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Insurances_GuarantorId",
                table: "Insurances",
                column: "GuarantorId");

            migrationBuilder.CreateIndex(
                name: "IX_LineNumbers_TransactionId",
                table: "LineNumbers",
                column: "TransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_NextOfKins_PatientAccountAccountId",
                table: "NextOfKins",
                column: "PatientAccountAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientAccounts_PersonId",
                table: "PatientAccounts",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_SubscriberId",
                table: "Patients",
                column: "SubscriberId");

            migrationBuilder.CreateIndex(
                name: "IX_Procedures_DiagnosisId",
                table: "Procedures",
                column: "DiagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_Providers_ClaimId",
                table: "Providers",
                column: "ClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_PtdScores_CallsToActionsCode",
                table: "PtdScores",
                column: "CallsToActionsCode");

            migrationBuilder.CreateIndex(
                name: "IX_PtdScores_PatientAccountAccountId",
                table: "PtdScores",
                column: "PatientAccountAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceLines_ClaimId",
                table: "ServiceLines",
                column: "ClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicePayments_ClaimPaymentId",
                table: "ServicePayments",
                column: "ClaimPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscribers_BillingProviderProviderId",
                table: "Subscribers",
                column: "BillingProviderProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscribers_EDI837MessageMessageId",
                table: "Subscribers",
                column: "EDI837MessageMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_PatientAccountAccountId",
                table: "Visits",
                column: "PatientAccountAccountId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eligibility");

            migrationBuilder.DropTable(
                name: "HL7Messages");

            migrationBuilder.DropTable(
                name: "LineNumbers");

            migrationBuilder.DropTable(
                name: "NextOfKins");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Procedures");

            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.DropTable(
                name: "PtdScores");

            migrationBuilder.DropTable(
                name: "ServiceLines");

            migrationBuilder.DropTable(
                name: "ServicePayments");

            migrationBuilder.DropTable(
                name: "Visits");

            migrationBuilder.DropTable(
                name: "Insurances");

            migrationBuilder.DropTable(
                name: "Diagnosis");

            migrationBuilder.DropTable(
                name: "CallsToActions");

            migrationBuilder.DropTable(
                name: "Claims");

            migrationBuilder.DropTable(
                name: "ClaimPayments");

            migrationBuilder.DropTable(
                name: "Guarantors");

            migrationBuilder.DropTable(
                name: "Subscribers");

            migrationBuilder.DropTable(
                name: "EDI835Messages");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "PatientAccounts");

            migrationBuilder.DropTable(
                name: "BillingProviders");

            migrationBuilder.DropTable(
                name: "EDI837Message");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
