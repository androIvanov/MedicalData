using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalData.Migrations
{
    public partial class fourteen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Visits",
                columns: table => new
                {
                    VIsitId = table.Column<int>(type: "int", nullable: false)
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
                    PatientStatusCode = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visits", x => x.VIsitId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Visits");
        }
    }
}
