using System;
using System.Collections.Generic;
using System.Text;
using MedicalData.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalData.EntityConfiguration
{
    class ServiceLineConfiguration : IEntityTypeConfiguration<ServiceLine>
    {
        public void Configure(EntityTypeBuilder<ServiceLine> builder)
        {
            builder.HasKey(k => k.ServiceLineId);
			builder.Property(x => x.ServiceLineId).HasColumnType("int").IsRequired();
			builder.Property(x => x.ClaimId).HasColumnType("int").IsRequired();
			builder.Property(x => x.ServiceIDQualifier).HasColumnType("nvarchar(2)").IsRequired();
			builder.Property(x => x.ServiceID).HasColumnType("nvarchar(50)").IsRequired();
			builder.Property(x => x.ProcedureModifier).HasColumnType("nvarchar(2)");
			builder.Property(x => x.MonetaryAmount).HasColumnType("decimal(18, 2)").IsRequired();
			builder.Property(x => x.UnitForMeasurementCode).HasColumnType("nvarchar(2)").IsRequired();
			builder.Property(x => x.Quantity).HasColumnType("decimal(8, 3)").IsRequired();
			builder.Property(x => x.FacilityCode).HasColumnType("nvarchar(2)");
			builder.Property(x => x.ServiceTypeCode).HasColumnType("nvarchar(2)");
			builder.Property(x => x.PrimaryDiagnosisCodePointer).HasColumnType("nvarchar(2)");
			builder.Property(x => x.SecondaryDiagnosisCodePointer).HasColumnType("nvarchar(2)");
			builder.Property(x => x.ServiceDateTime).HasColumnType("datetime").IsRequired();
		}
    }
}
