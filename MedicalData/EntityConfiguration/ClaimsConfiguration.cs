using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MedicalData.Entities;
namespace MedicalData.EntityConfiguration 
{
    class ClaimsConfiguration : IEntityTypeConfiguration<Claims>
    {
        public void Configure(EntityTypeBuilder<Claims> builder)
        {
			builder.HasKey(x => x.ClaimId);
			builder.Property(x => x.SubscriberId).HasColumnType("int").IsRequired();
			builder.Property(x => x.PatientControlNumber).HasColumnType("nvarchar(38)").IsRequired();
			builder.Property(x => x.MonetaryAmount).HasColumnType("decimal(18, 2)").IsRequired();
			builder.Property(x => x.FacilityCodeValue).HasColumnType("nvarchar(2)").IsRequired();
			builder.Property(x => x.FacilityCodeQualifier).HasColumnType("nvarchar(2)").IsRequired();
			builder.Property(x => x.ClaimFrequencyTypeCode).HasColumnType("nchar(1)").IsRequired();
			builder.Property(x => x.SignatureOnFileIndicator).HasColumnType("nchar(1)");
			builder.Property(x => x.ProviderAcceptAssignmentCode).HasColumnType("nchar(1)");
			builder.Property(x => x.AssignmentOfBenefitsIndicator).HasColumnType("nchar(1)");
			builder.Property(x => x.RelatedCausesCode).HasColumnType("nvarchar(3)");
			builder.Property(x => x.OnsetDate).HasColumnType("date");
			builder.Property(x => x.DTP434).HasColumnType("nvarchar(20)");
			builder.Property(x => x.PrincipalDiagnosisCode).HasColumnType("nvarchar(30)");
			builder.Property(x => x.AdditionalDiagnosisCode1).HasColumnType("nvarchar(30)");
			builder.Property(x => x.AdditionalDiagnosisCode2).HasColumnType("nvarchar(30)");
			builder.Property(x => x.OccurrenceCode).HasColumnType("nvarchar(2)");
			builder.Property(x => x.OccurenceDate).HasColumnType("date");
			builder.Property(x => x.InstitutionalAdmissionTypeCode).HasColumnType("nchar(1)");
			builder.Property(x => x.InstitutionalAdmissionSourceCode).HasColumnType("nchar(1)");
			builder.Property(x => x.InstitutionalInstitutionalPatientStatusCode).HasColumnType("nvarchar(2)");
			builder.Property(x => x.ClaimRefferenceId).HasColumnType("nvarchar(50)");

			// realtions

			builder.HasOne(r => r.Subscriber);
			builder.HasMany(r => r.ServiceLines);
			builder.HasMany(r => r.Providers);
		}
    }
}
