using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MedicalData.Entities;
using System;

namespace MedicalData.EntityConfiguration
{
    class ClaimPaymentsConfiguration : IEntityTypeConfiguration<ClaimPayments>
    {
        public void Configure(EntityTypeBuilder<ClaimPayments> builder)
        { 
            builder.HasKey(p => p.ClaimPaymentId);
            builder.Property(p => p.ClaimPaymentId).HasColumnType("int").IsRequired();
            builder.Property(p => p.TransactionId).HasColumnType("int").IsRequired();
            builder.Property(p => p.MessageId).HasColumnType("int").IsRequired();
            builder.Property(p => p.PatientControlNumber).HasColumnType("nvarchar(38)").IsRequired();
            builder.Property(p => p.ClaimStatusCode).HasColumnType("nvarchar(2)").IsRequired();
            builder.Property(p => p.TotalClaimChargeAmount).HasColumnType("decimal(18, 2)").IsRequired();
            builder.Property(p => p.ClaimPaymentAmount).HasColumnType("decimal(18, 2)").IsRequired();
            builder.Property(p => p.PatientResponsibilityAmount).HasColumnType("decimal(18, 2)").IsRequired();
            builder.Property(p => p.ClaimFilingIndicatorCode).HasColumnType("nvarchar(2)").IsRequired();
            builder.Property(p => p.PayerClaimControlNumber).HasColumnType("nvarchar(50)");
            builder.Property(p => p.FacilityCodeValue).HasColumnType("nvarchar(2)");
            builder.Property(p => p.ClaimFrequencyTypeCode).HasColumnType("nchar(1)");
            builder.Property(p => p.PatientEntityTypeQualifier).HasColumnType("nchar(1)").IsRequired();
            builder.Property(p => p.PatientLastName).HasColumnType("nvarchar(60)");
            builder.Property(p => p.PatientFirstName).HasColumnType("nvarchar(35)");
            builder.Property(p => p.PatientMiddleName).HasColumnType("nvarchar(25)");
            builder.Property(p => p.SubscriberEntiryTypeQualifier).HasColumnType("nvarchar(1)");
            builder.Property(p => p.SubscriberLastName).HasColumnType("nvarchar(60)");
            builder.Property(p => p.SubscriberFirstName).HasColumnType("nvarchar(35)");
            builder.Property(p => p.SubscriberMiddleName).HasColumnType("nvarchar(25)");
            builder.Property(p => p.SubscribreNameSuffix).HasColumnType("nvarchar(25)");
            builder.Property(p => p.SubscriberIdCodeQualifier).HasColumnType("nvarchar(2)");
            builder.Property(p => p.SubscriberIdentifierCode).HasColumnType("nvarchar(80)");
            builder.Property(p => p.CorrectedSubscriberEntiryTypeQualifier).HasColumnType("nvarchar(1)");
            builder.Property(p => p.CorrectedSubscriberLastName).HasColumnType("nvarchar(60)");
            builder.Property(p => p.CorrectedSubscriberFirstName).HasColumnType("nvarchar(35)");
            builder.Property(p => p.CorrectedSubscriberMiddleName).HasColumnType("nvarchar(25)");
            builder.Property(p => p.CorrectedSubscribreNameSuffix).HasColumnType("nchar(10)");
            builder.Property(p => p.RenderingProviderEntityTypeQualifier).HasColumnType("nvarchar(1)");
            builder.Property(p => p.RenderingProviderLastName).HasColumnType("nvarchar(60)");
            builder.Property(p => p.RenderingProviderFirstName).HasColumnType("nvarchar(35)");
            builder.Property(p => p.RenderingProviderMiddleName).HasColumnType("nvarchar(25)");
            builder.Property(p => p.RenderingProviderNameSuffix).HasColumnType("nvarchar(10)");
            builder.Property(p => p.RenderingProviderIdCodeQualifier).HasColumnType("nvarchar(2)");
            builder.Property(p => p.RenderingProviderId).HasColumnType("nvarchar(80)");
            builder.Property(p => p.ClaimRecivedDate).HasColumnType("date").IsRequired();
            builder.Property(p => p.ClaimPaymentPeriodStartDate).HasColumnType("date");
            builder.Property(p => p.ClaimPaymentPeriodEndDate).HasColumnType("date");
            builder.Property(p => p.ClaimContactComunicationsNumberQualifier).HasColumnType("nvarchar(2)");
            builder.Property(p => p.ClaimContactComunicationsNumber).HasColumnType("nvarchar(256)");
            builder.Property(p => p.CoverageAmount).HasColumnType("decimal(18, 2)");

            // relations

            builder.HasOne(r => r.EDI835Message);
            builder.HasMany(r => r.ServicePayments);
            builder.HasOne(r => r.Transaction);

            // seeding

            //builder.HasData(
            //    new ClaimPayments 
            //    {
            //        ClaimPaymentId = 1,
            //        TransactionId = 1,
            //        MessageId = 1,
            //        PatientControlNumber = "JHGE578TOH4",
            //        ClaimStatusCode = "PS",
            //        TotalClaimChargeAmount = 567,
            //        ClaimPaymentAmount = 999,
            //        ClaimFilingIndicatorCode = "JA",
            //        PatientEntityTypeQualifier = "S",
            //        ClaimRecivedDate = DateTime.UtcNow
            //    }
            //);
        }
    }
}
