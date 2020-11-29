using MedicalData.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalData.EntityConfiguration
{
    class ProcedureConfiguration : IEntityTypeConfiguration<Procedure>
    {
        public void Configure(EntityTypeBuilder<Procedure> builder)
        {
            builder.HasKey(k => k.ProcedureId);
            builder.Property(x => x.ProcedureId).HasColumnType("int").IsRequired();
            builder.Property(x => x.DiagnosisId).HasColumnType("int").IsRequired();
            builder.Property(x => x.SerID).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.ProcedureCodingMethod).HasColumnType("nvarchar(50)");
            builder.Property(x => x.ProcedureCode).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.ProcedureDescription).HasColumnType("nvarchar(255)").IsRequired();
            builder.Property(x => x.ProcedureDateTime).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.AssociatedDiagnosis).HasColumnType("nvarchar(255)");

            // relations

            builder.HasOne(r => r.Diagnosis);
        }
    }
}
