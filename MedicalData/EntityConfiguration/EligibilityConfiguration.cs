using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MedicalData.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalData.EntityConfiguration
{
    class EligibilityConfiguration : IEntityTypeConfiguration<Eligibility>
    {
        public void Configure(EntityTypeBuilder<Eligibility> builder)
        {
            builder.HasKey(k => k.EligibilityId);
            builder.Property(p => p.EligibilityId).HasColumnType("int").IsRequired();
            builder.Property(p => p.InsuranceId).HasColumnType("int").IsRequired();
            builder.Property(p => p.SetID).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(p => p.EligibilityStatus).HasColumnType("nvarchar(100)");
            builder.Property(p => p.COBSequence).HasColumnType("int").IsRequired();
            builder.Property(p => p.SetIDZM2).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(p => p.UnpaidBalance).HasColumnType("decimal(18, 4)");
            builder.Property(p => p.UnpaidBalanceType).HasColumnType("nvarchar(50)");
        }
    }
}
