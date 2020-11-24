using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalData.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    PlanExpirationDate = table.Column<DateTime>(type: "date", nullable: false),
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
                    VerificationDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
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
                    CertificationDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    CertificationModifyDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
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
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Insurances");
        }
    }
}
