using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalData.EntityConfiguration
{
    class BillingProviderConfiguration : IEntityTypeConfiguration<BillingProviders>
    {
        public void Configure(EntityTypeBuilder<BillingProviders> builder)
        {
            builder.HasKey(p => p.ProviderId);
            builder.Property(p => p.ProviderId).HasColumnType("int").IsRequired();
            builder.Property(p => p.ProviderCode).HasColumnType("nvarchar(10)");
            builder.Property(p => p.ReferenceIdQualifier).HasColumnType("nvarchar(10)");
            builder.Property(p => p.ReferenceID).HasColumnType("nvarchar(50)");
            builder.Property(p => p.EntityTypeQualifier).HasColumnType("nvarchar(1)");
            builder.Property(p => p.NameLast).HasColumnType("nvarchar(60)");
            builder.Property(p => p.NameFirst).HasColumnType("nvarchar(50)");
            builder.Property(p => p.NameMiddle).HasColumnType("nvarchar(50)");
            builder.Property(p => p.NamePrefix).HasColumnType("nvarchar(10)");
            builder.Property(p => p.NameSuffix).HasColumnType("nvarchar(10)");
            builder.Property(p => p.IdentificationCodeQualifier).HasColumnType("nvarchar(2)");
            builder.Property(p => p.IdentificationCode).HasColumnType("nvarchar(80)");
            builder.Property(p => p.Addres).HasColumnType("nvarchar(80)");
            builder.Property(p => p.City).HasColumnType("nvarchar(50)");
            builder.Property(p => p.State).HasColumnType("nvarchar(2)");
            builder.Property(p => p.Zip).HasColumnType("nvarchar(10)");
            builder.Property(p => p.TaxReferenceIdQualifier).HasColumnType("nvarchar(3)");
            builder.Property(p => p.TaxReferenceId).HasColumnType("nvarchar(50)");
        }
    }
}
