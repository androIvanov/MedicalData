using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MedicalData.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalData.EntityConfiguration
{
    class LineNumberConfiguration : IEntityTypeConfiguration<LineNumber>
    {
        public void Configure(EntityTypeBuilder<LineNumber> builder)
        {
            builder.HasKey(k => k.LineNumberId);
            builder.Property(x => x.LineNumberId).HasColumnType("int").IsRequired();
            builder.Property(x => x.TransactionId).HasColumnType("int").IsRequired();
            builder.Property(x => x.ProviderId).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.FacilityTypeCode).HasColumnType("nvarchar(2)").IsRequired();
            builder.Property(x => x.FiscalPeriodDate).HasColumnType("date").IsRequired();
            builder.Property(x => x.TotalClaimCount).HasColumnType("int").IsRequired();
            builder.Property(x => x.TotalClaimChargeAmount).HasColumnType("decimal(18, 2)").IsRequired();
        }
    }
}
