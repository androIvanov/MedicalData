using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MedicalData.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalData.EntityConfiguration
{
    class DiagnosisConfiguration : IEntityTypeConfiguration<Diagnosis>
    {
        public void Configure(EntityTypeBuilder<Diagnosis> builder)
        {
            builder.HasKey(k => k.DiagnosisId);
            builder.Property(x => x.DiagnosisId).HasColumnType("int").IsRequired();
            builder.Property(x => x.SetID).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.DiagnosisCodingMethod).HasColumnType("nvarchar(50)");
            builder.Property(x => x.DiagnosisCode).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.DiagnosisDescription).HasColumnType("nvarchar(255)").IsRequired();
            builder.Property(x => x.DiagnosisDateTime).HasColumnType("datetime");
            builder.Property(x => x.DiagnosisType).HasColumnType("nvarchar(50)");
            builder.Property(x => x.DiagnosticRelatedGroup).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.AccountId).HasColumnType("int").IsRequired();
        }

    }
}
