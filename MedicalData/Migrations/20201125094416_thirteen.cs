using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalData.Migrations
{
    public partial class thirteen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropTable(
                name: "Guarantors");

            migrationBuilder.DropTable(
                name: "HL7Messages");

            migrationBuilder.DropTable(
                name: "Insurances");

            migrationBuilder.DropTable(
                name: "LineNumbers");

            migrationBuilder.DropTable(
                name: "NextOfKins");

            migrationBuilder.DropTable(
                name: "PatientAccounts");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Procedures");

            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.DropTable(
                name: "ServiceLines");

            migrationBuilder.DropTable(
                name: "ServicePayments");

            migrationBuilder.DropTable(
                name: "Subscribers");

            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
