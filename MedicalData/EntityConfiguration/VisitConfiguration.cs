using Microsoft.EntityFrameworkCore;
using MedicalData.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace MedicalData.EntityConfiguration
{
    class VisitConfiguration : IEntityTypeConfiguration<Visit>
    {
        public void Configure(EntityTypeBuilder<Visit> builder)
        {
            builder.HasKey(k => k.VisitId);
			builder.Property(x => x.VisitId).HasColumnType("int").IsRequired();
			builder.Property(x => x.SetID).HasColumnType("nvarchar(50)").IsRequired();
			builder.Property(x => x.PatientClass).HasColumnType("nvarchar(50)").IsRequired();
			builder.Property(x => x.AssignedLocation).HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(x => x.AdmissionType).HasColumnType("nvarchar(50)");
			builder.Property(x => x.PreAdmitNumber).HasColumnType("nvarchar(50)");
			builder.Property(x => x.PriorLocation).HasColumnType("nvarchar(255)");
			builder.Property(x => x.AttendingDoctorID).HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(x => x.AttendingDoctorFamilyName).HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(x => x.AttendingDoctorGivenName).HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(x => x.AttendingDoctorMiddleName).HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(x => x.AttendingDoctorSuffix).HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(x => x.AttendingDoctorPrefix).HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(x => x.ReferringDoctor).HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(x => x.ConsultingDoctor).HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(x => x.HospitalService).HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(x => x.TemporaryLocation).HasColumnType("nvarchar(255)");
			builder.Property(x => x.PreAdmitTestIndicator).HasColumnType("nvarchar(50)");
			builder.Property(x => x.ReadmissionIndicator).HasColumnType("nvarchar(50)");
			builder.Property(x => x.AdmitSource).HasColumnType("nvarchar(50)");
			builder.Property(x => x.AmbulatoryStatus).HasColumnType("nvarchar(50)");
			builder.Property(x => x.VipIndicator).HasColumnType("nvarchar(50)");
			builder.Property(x => x.AdmittingDoctorID).HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(x => x.AdmittingDoctorFamilyName).HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(x => x.AdmittingDoctorGivenName).HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(x => x.AdmittingDoctorMiddleName).HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(x => x.AdmittingDoctorSuffix).HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(x => x.AdmittingDoctorPrefix).HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(x => x.PatientType).HasColumnType("nvarchar(50)").IsRequired();
			builder.Property(x => x.VisitNumber).HasColumnType("nvarchar(50)").IsRequired();
			builder.Property(x => x.FinancialClass).HasColumnType("nvarchar(50)").IsRequired();
			builder.Property(x => x.CourtesyCode).HasColumnType("nvarchar(50)");
			builder.Property(x => x.ContractCode).HasColumnType("nvarchar(50)");
			builder.Property(x => x.ContractEffectiveDate).HasColumnType("date");
			builder.Property(x => x.ContractAmount).HasColumnType("decimal(18, 4)");
			builder.Property(x => x.ContractPeriod).HasColumnType("int");
			builder.Property(x => x.InterestCode).HasColumnType("nvarchar(50)");
			builder.Property(x => x.DeleteAccountIndicator).HasColumnType("nvarchar(50)").IsRequired();
			builder.Property(x => x.DeleteAccountDate).HasColumnType("date").IsRequired();
			builder.Property(x => x.DischargeDisposition).HasColumnType("nvarchar(255)");
			builder.Property(x => x.DischargeToLocation).HasColumnType("nvarchar(255)");
			builder.Property(x => x.ServicingFacility).HasColumnType("nvarchar(255)");
			builder.Property(x => x.BedStatus).HasColumnType("nvarchar(50)");
			builder.Property(x => x.AccountStatus).HasColumnType("nvarchar(50)").IsRequired();
			builder.Property(x => x.PendingLocation).HasColumnType("nvarchar(50)");
			builder.Property(x => x.PriorTemporaryLocation).HasColumnType("nvarchar(50)");
			builder.Property(x => x.AdmitDateTime).HasColumnType("datetime").IsRequired();
			builder.Property(x => x.DischargeDateTime).HasColumnType("datetime").IsRequired();
			builder.Property(x => x.CurrentPatientBalance).HasColumnType("decimal(18, 4)");
			builder.Property(x => x.TotalCharges).HasColumnType("decimal(18, 4)");
			builder.Property(x => x.TotalAdjustments).HasColumnType("decimal(18, 4)");
			builder.Property(x => x.TotalPayments).HasColumnType("decimal(18, 4)");
			builder.Property(x => x.AlternateVisitID).HasColumnType("nvarchar(50)");
			builder.Property(x => x.VisitIndicator).HasColumnType("nvarchar(50)");
			builder.Property(x => x.AccountId).HasColumnType("int").IsRequired();
			builder.Property(x => x.AccommodationCode).HasColumnType("nvarchar(50)");
			builder.Property(x => x.AdmitReason).HasColumnType("nvarchar(255)");
			builder.Property(x => x.TransferReason).HasColumnType("nvarchar(255)");
			builder.Property(x => x.ExpectedAdmitDate).HasColumnType("date");
			builder.Property(x => x.ExpectedDischargeDate).HasColumnType("date");
			builder.Property(x => x.EstimatedLengthOfIPstay).HasColumnType("int");
			builder.Property(x => x.ActualLengthOfIPStay).HasColumnType("int");
			builder.Property(x => x.VisitDescription).HasColumnType("nvarchar(255)");
			builder.Property(x => x.ReferralSourceCode).HasColumnType("nvarchar(50)");
			builder.Property(x => x.PatientStatusCode).HasColumnType("nvarchar(50)");

			// relations

			builder.HasOne(r => r.PatientAccount);
        }
    }
}
