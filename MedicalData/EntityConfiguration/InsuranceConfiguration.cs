using MedicalData.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalData.EntityConfiguration
{
    class InsuranceConfiguration : IEntityTypeConfiguration<Insurance>
    {
        public void Configure(EntityTypeBuilder<Insurance> builder)
        {
			builder.HasKey(k => k.InsuranceId);
			builder.Property(p => p.InsuranceId).HasColumnType("int").IsRequired();
			builder.Property(p => p.GuarantorId).HasColumnType("int").IsRequired();
			builder.Property(p => p.SetID).HasColumnType("nvarchar(50)").IsRequired();
			builder.Property(p => p.PlanCode).HasColumnType("nvarchar(50)").IsRequired();
			builder.Property(p => p.CompanyID).HasColumnType("nvarchar(50)").IsRequired();
			builder.Property(p => p.CompanyName).HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(p => p.CompanyAddress).HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(p => p.CompanyPhoneNumber).HasColumnType("nvarchar(50)").IsRequired();
			builder.Property(p => p.GroupNumber).HasColumnType("nvarchar(50)").IsRequired();
			builder.Property(p => p.GroupName).HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(p => p.PlanEffectiveDate).HasColumnType("date");
			builder.Property(p => p.PlanExpirationDate).HasColumnType("datetime");
			builder.Property(p => p.AuthorizationInformation).HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(p => p.PlanType).HasColumnType("nvarchar(50)").IsRequired();
			builder.Property(p => p.InsuredFamilyName).HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(p => p.InsuredGivenName).HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(p => p.InsuredMiddleName).HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(p => p.InsuredSuffix).HasColumnType("nvarchar(50)").IsRequired();
			builder.Property(p => p.RelationshiptoPatient).HasColumnType("nvarchar(50)").IsRequired();
			builder.Property(p => p.InsuredsDateOfBirth).HasColumnType("date").IsRequired(); ////////////
			builder.Property(p => p.InsuredsAddress).HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(p => p.CoordinationofBenefits).HasColumnType("nvarchar(255)");
			builder.Property(p => p.CoordinationBenefitsPriority).HasColumnType("nvarchar(50)");
			builder.Property(p => p.NoticeofAdmissionCode).HasColumnType("varbinary(50)");
			builder.Property(p => p.NoticeofAdmissionDate).HasColumnType("date");
			builder.Property(p => p.ReportofEligibilityCode).HasColumnType("varbinary(50)").IsRequired();
			builder.Property(p => p.ReportofEligibilityDate).HasColumnType("date").IsRequired();
			builder.Property(p => p.PreAdmitCertification).HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(p => p.VerificationDateTime).HasColumnType("date").IsRequired();
			builder.Property(p => p.VerificationBy).HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(p => p.BillingStatus).HasColumnType("nvarchar(50)");
			builder.Property(p => p.CompanyPlanCode).HasColumnType("nvarchar(50)");
			builder.Property(p => p.PolicyNumber).HasColumnType("nvarchar(50)");
			builder.Property(p => p.VerificationStatus).HasColumnType("nvarchar(50)");
			builder.Property(p => p.PriorInsurancePlanID).HasColumnType("nvarchar(50)");
			builder.Property(p => p.InsuredsIDNumber).HasColumnType("nvarchar(50)").IsRequired();
			builder.Property(p => p.SetIDIN2).HasColumnType("nvarchar(50)").IsRequired();
			builder.Property(p => p.InsuredsSSN).HasColumnType("nvarchar(50)");
			builder.Property(p => p.InsuredsEmployerName).HasColumnType("nvarchar(255)");
			builder.Property(p => p.SetIDIN3).HasColumnType("nvarchar(50)").IsRequired();
			builder.Property(p => p.CertificationNumber).HasColumnType("nvarchar(50)");
			builder.Property(p => p.CertifiedBy).HasColumnType("nvarchar(50)");
			builder.Property(p => p.CertificationRequired).HasColumnType("nvarchar(50)");
			builder.Property(p => p.CertificationDateTime).HasColumnType("date");
			builder.Property(p => p.CertificationModifyDateTime).HasColumnType("date");
			builder.Property(p => p.Operator).HasColumnType("nvarchar(255)");
			builder.Property(p => p.CertificationBeginDate).HasColumnType("date");
			builder.Property(p => p.CertificationEndDate).HasColumnType("date");
			builder.Property(p => p.Days).HasColumnType("int");
			builder.Property(p => p.CertificationAgency).HasColumnType("nvarchar(255)");
			builder.Property(p => p.PreCertificationReqWindow).HasColumnType("nvarchar(255)");

			// relations

			builder.HasOne(r => r.Guarantor);
			builder.HasMany(r => r.Eligibilities);
		}
    }
}
