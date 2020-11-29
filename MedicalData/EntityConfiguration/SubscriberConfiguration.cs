using Microsoft.EntityFrameworkCore;
using MedicalData.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalData.EntityConfiguration
{
    class SubscriberConfiguration : IEntityTypeConfiguration<Subscriber>
    {
        public void Configure(EntityTypeBuilder<Subscriber> builder)
        {
            builder.HasKey(k => k.SubscriberId);
			builder.Property(x => x.SubscriberId).HasColumnType("int").IsRequired();
			builder.Property(x => x.ProviderId).HasColumnType("int").IsRequired();
			builder.Property(x => x.MessageId).HasColumnType("int").IsRequired();
			builder.Property(x => x.PayerResponsibilitySequenceNumberCode).HasColumnType("nchar(1)").IsRequired();
			builder.Property(x => x.IndividualRelationshipCode).HasColumnType("nvarchar(2)");
			builder.Property(x => x.ReferenceIdentification).HasColumnType("nvarchar(50))");
			builder.Property(x => x.Name).HasColumnType("nvarchar(60)");
			builder.Property(x => x.InsuranceTypeCode).HasColumnType("nvarchar(3)");
			builder.Property(x => x.ClaimFilingIndicatorCode).HasColumnType("nvarchar(2)");
			builder.Property(x => x.SubscriberEntityTypeQualifier).HasColumnType("nchar(1)");
			builder.Property(x => x.SubscriberNameLast).HasColumnType("nvarchar(60)");
			builder.Property(x => x.SubscriberNameFirst).HasColumnType("nvarchar(50)");
			builder.Property(x => x.SubscriberNameMidle).HasColumnType("nvarchar(50)");
			builder.Property(x => x.SubscriberNamePrefix).HasColumnType("nvarchar(10)");
			builder.Property(x => x.SubscriberNameSuffix).HasColumnType("nvarchar(10)");
			builder.Property(x => x.SubscriberIdentificationCodeQualifier).HasColumnType("nvarchar(2)");
			builder.Property(x => x.SubscriberIdentificationCode).HasColumnType("nvarchar(80)");
			builder.Property(x => x.SubscriberAddress).HasColumnType("nvarchar(80)");
			builder.Property(x => x.SubscriberCity).HasColumnType("nvarchar(50)");
			builder.Property(x => x.SubscriberState).HasColumnType("nvarchar(2)");
			builder.Property(x => x.SubscriberZip).HasColumnType("nvarchar(10)");
			builder.Property(x => x.SubscriberDateOfBirth).HasColumnType("datetime");
			builder.Property(x => x.SubscriberSex).HasColumnType("nvarchar(1)");
			builder.Property(x => x.PayerEntityTypeQualifier).HasColumnType("nvarchar(1)");
			builder.Property(x => x.PayerNameLast).HasColumnType("nvarchar(50)");
			builder.Property(x => x.PayerNameFirst).HasColumnType("nvarchar(50)");
			builder.Property(x => x.PayerNameMidle).HasColumnType("nvarchar(50)");
			builder.Property(x => x.PayerNamePrefix).HasColumnType("nvarchar(10)");
			builder.Property(x => x.PayerNameSuffix).HasColumnType("nvarchar(10)");
			builder.Property(x => x.PayerIdentificationCodeQualifier).HasColumnType("nvarchar(2)");
			builder.Property(x => x.PayerIdentificationCode).HasColumnType("nvarchar(80)");
			builder.Property(x => x.PayerAddress).HasColumnType("nvarchar(80)");
			builder.Property(x => x.PayerCity).HasColumnType("nvarchar(50)");
			builder.Property(x => x.PayerState).HasColumnType("nvarchar(2)");
			builder.Property(x => x.PayerZip).HasColumnType("nvarchar(10)");

			// relations

			builder.HasOne(r => r.EDI837Message);
			builder.HasMany(r => r.Patients);
			builder.HasOne(r => r.BillingProvider);
			builder.HasMany(r => r.Claims);
		}
    }
}
