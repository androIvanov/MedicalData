using Microsoft.EntityFrameworkCore;
using MedicalData.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalData.EntityConfiguration
{
    class ServicePaymentConfiguration : IEntityTypeConfiguration<ServicePayment>
    {
        public void Configure(EntityTypeBuilder<ServicePayment> builder)
        {
            builder.HasKey(k => k.ServicePaymentId);
			builder.Property(x => x.ServicePaymentId).HasColumnType("int").IsRequired();
			builder.Property(x => x.ClaimPaymentId).HasColumnType("int").IsRequired();
			builder.Property(x => x.ServiceIdQualifier).HasColumnType("nvarchar(2)").IsRequired();
			builder.Property(x => x.AdjudicatedProcedureCode).HasColumnType("nvarchar(48)").IsRequired();
			builder.Property(x => x.ProcedureModifier).HasColumnType("nvarchar(2)");
			builder.Property(x => x.LineItemChargeAmount).HasColumnType("decimal(18, 2)").IsRequired();
			builder.Property(x => x.LineItemProviderPaymentAmount).HasColumnType("decimal(18, 2)").IsRequired();
			builder.Property(x => x.NUBCRevenueCode).HasColumnType("nvarchar(48)");
			builder.Property(x => x.UnitsOfServicePaidCount).HasColumnType("int").IsRequired();
			builder.Property(x => x.MedicalProcedureIdQualifier).HasColumnType("nvarchar(2)");
			builder.Property(x => x.MedicalProcedureCode).HasColumnType("nvarchar(48)");
			builder.Property(x => x.MedicalProcedureModifier).HasColumnType("nvarchar(2)");
			builder.Property(x => x.ServiceDate).HasColumnType("date");
			builder.Property(x => x.ClaimAdjustmentGroupCode).HasColumnType("nvarchar(2)");
			builder.Property(x => x.AdjustmentReasonCode).HasColumnType("nvarchar(5)");
			builder.Property(x => x.AdjustmentAmount).HasColumnType("decimal(18, 2)");
			builder.Property(x => x.AdjustmentQuantity).HasColumnType("int");
			builder.Property(x => x.LineItemControlNumber).HasColumnType("nvarchar(50)");
			builder.Property(x => x.ServiceSupplementalAmountQualifierCode).HasColumnType("nvarchar(3)");
			builder.Property(x => x.ServiceSupplementalAmount).HasColumnType("decimal(18, 2)");

			// relations

			builder.HasOne(r => r.ClaimPayment);
		}
    }
}
