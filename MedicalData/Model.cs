using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace MedicalData
{
    class Model : DbContext
    {
        public DbSet<ClaimPayments> ClaimPayments { get; set; }
        public DbSet<CallsToActions> CallsToActions { get; set; }
        public DbSet<BillingProviders> BillingProviders { get; set; }

        private const string connectionString = "server=localhost; database=Medical; Integrated Security=true";

        protected override void OnConfiguring(DbContextOptionsBuilder contextOptions)
        {
            contextOptions.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClaimPayments>(x =>
            {
                x.HasKey(p => p.ClaimPaymentId);
                x.Property(p => p.ClaimPaymentId).HasColumnType("int").IsRequired();
                x.Property(p => p.TransactionId).HasColumnType("int").IsRequired();
                x.Property(p => p.MessageId).HasColumnType("int").IsRequired();
                x.Property(p => p.PatientControlNumber).HasColumnType("nvarchar(38)").IsRequired();
                x.Property(p => p.ClaimStatusCode).HasColumnType("nvarchar(2)").IsRequired();
                x.Property(p => p.TotalClaimChargeAmount).HasColumnType("decimal(18, 2)").IsRequired();
                x.Property(p => p.ClaimPaymentAmount).HasColumnType("decimal(18, 2)").IsRequired();
                x.Property(p => p.PatientResponsibilityAmount).HasColumnType("decimal(18, 2)").IsRequired();
                x.Property(p => p.ClaimFilingIndicatorCode).HasColumnType("nvarchar(2)").IsRequired();
                x.Property(p => p.PayerClaimControlNumber).HasColumnType("nvarchar(50)");
                x.Property(p => p.FacilityCodeValue).HasColumnType("nvarchar(2)");
                x.Property(p => p.ClaimFrequencyTypeCode).HasColumnType("nchar(1)");
                x.Property(p => p.PatientEntityTypeQualifier).HasColumnType("nchar(1)").IsRequired();
                x.Property(p => p.PatientLastName).HasColumnType("nvarchar(60)");
                x.Property(p => p.PatientFirstName).HasColumnType("nvarchar(35)");
                x.Property(p => p.PatientMiddleName).HasColumnType("nvarchar(25)");
                x.Property(p => p.SubscriberEntiryTypeQualifier).HasColumnType("nvarchar(1)");
                x.Property(p => p.SubscriberLastName).HasColumnType("nvarchar(60)");
                x.Property(p => p.SubscriberFirstName).HasColumnType("nvarchar(35)");
                x.Property(p => p.SubscriberMiddleName).HasColumnType("nvarchar(25)");
                x.Property(p => p.SubscribreNameSuffix).HasColumnType("nvarchar(25)");
                x.Property(p => p.SubscriberIdCodeQualifier).HasColumnType("nvarchar(2)");
                x.Property(p => p.SubscriberIdentifierCode).HasColumnType("nvarchar(80)");
                x.Property(p => p.CorrectedSubscriberEntiryTypeQualifier).HasColumnType("nvarchar(1)");
                x.Property(p => p.CorrectedSubscriberLastName).HasColumnType("nvarchar(60)");
                x.Property(p => p.CorrectedSubscriberFirstName).HasColumnType("nvarchar(35)");
                x.Property(p => p.CorrectedSubscriberMiddleName).HasColumnType("nvarchar(25)");
                x.Property(p => p.CorrectedSubscribreNameSuffix).HasColumnType("nchar(10)");
                x.Property(p => p.RenderingProviderEntityTypeQualifier).HasColumnType("nvarchar(1)");
                x.Property(p => p.RenderingProviderLastName).HasColumnType("nvarchar(60)");
                x.Property(p => p.RenderingProviderFirstName).HasColumnType("nvarchar(35)");
                x.Property(p => p.RenderingProviderMiddleName).HasColumnType("nvarchar(25)");
                x.Property(p => p.RenderingProviderNameSuffix).HasColumnType("nvarchar(10)");
                x.Property(p => p.RenderingProviderIdCodeQualifier).HasColumnType("nvarchar(2)");
                x.Property(p => p.RenderingProviderId).HasColumnType("nvarchar(80)");
                x.Property(p => p.ClaimRecivedDate).HasColumnType("date").IsRequired();
                x.Property(p => p.ClaimPaymentPeriodStartDate).HasColumnType("date");
                x.Property(p => p.ClaimPaymentPeriodEndDate).HasColumnType("date");
                x.Property(p => p.ClaimContactComunicationsNumberQualifier).HasColumnType("nvarchar(2)");
                x.Property(p => p.ClaimContactComunicationsNumber).HasColumnType("nvarchar(256)");
                x.Property(p => p.CoverageAmount).HasColumnType("decimal(18, 2)");
            });


            modelBuilder.Entity<CallsToActions>(x =>
            {
                x.HasKey(p => p.Code);
                x.Property(p => p.Code).IsRequired().HasColumnType("nvarchar(50)");
                x.Property(p => p.PtdCoeficient).IsRequired().HasColumnType("int");
                x.Property(p => p.Action1).HasColumnType("nvarchar(255)");
                x.Property(p => p.Action2).HasColumnType("nvarchar(255)");
            });

            modelBuilder.Entity<BillingProviders>(x =>
            {
                x.HasKey(p => p.ProviderId);
                x.Property(p => p.ProviderId).IsRequired();
                x.Property(p => p.ProviderCode).HasColumnType("nvarchar(10)");
                x.Property(p => p.ReferenceIdQualifier).HasColumnType("nvarchar(10)");
                x.Property(p => p.ReferenceID).HasColumnType("nvarchar(50)");
                x.Property(p => p.EntityTypeQualifier).HasColumnType("nvarchar(1)");
                x.Property(p => p.NameLast).HasColumnType("nvarchar(60)");
                x.Property(p => p.NameFirst).HasColumnType("nvarchar(50)");
                x.Property(p => p.NameMiddle).HasColumnType("nvarchar(50)");
                x.Property(p => p.NamePrefix).HasColumnType("nvarchar(10)");
                x.Property(p => p.NameSuffix).HasColumnType("nvarchar(10)");
                x.Property(p => p.IdentificationCodeQualifier).HasColumnType("nvarchar(2)");
                x.Property(p => p.IdentificationCode).HasColumnType("nvarchar(80)");
                x.Property(p => p.Addres).HasColumnType("nvarchar(80)");
                x.Property(p => p.City).HasColumnType("nvarchar(50)");
                x.Property(p => p.State).HasColumnType("nvarchar(2)");
                x.Property(p => p.Zip).HasColumnType("nvarchar(10)");
                x.Property(p => p.TaxReferenceIdQualifier).HasColumnType("nvarchar(3)");
                x.Property(p => p.TaxReferenceId).HasColumnType("nvarchar(50)");
            });


        }
    }

}