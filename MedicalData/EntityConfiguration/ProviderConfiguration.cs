using MedicalData.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalData.EntityConfiguration
{
    class ProviderConfiguration : IEntityTypeConfiguration<Provider>
    {
        public void Configure(EntityTypeBuilder<Provider> builder)
        {
            builder.HasKey(k => k.ProviderId);
			builder.Property(x => x.ProviderId).HasColumnType("int").IsRequired();
			builder.Property(x => x.ClaimId).HasColumnType("int").IsRequired();
			builder.Property(x => x.EntityIdCode).HasColumnType("nchar(2)").IsRequired();
			builder.Property(x => x.EntityTypeQualifier).HasColumnType("nchar(1)").IsRequired();
			builder.Property(x => x.NameLast).HasColumnType("nvarchar(50)");
			builder.Property(x => x.NameFirst).HasColumnType("nvarchar(50)");
			builder.Property(x => x.NameMidle).HasColumnType("nvarchar(50)");
			builder.Property(x => x.NamePrefix).HasColumnType("nvarchar(10)");
			builder.Property(x => x.NameSuffix).HasColumnType("nvarchar(10)");
			builder.Property(x => x.IdCodeQualifier).HasColumnType("nvarchar(2)");
			builder.Property(x => x.IdCode).HasColumnType("nvarchar(80)");
			builder.Property(x => x.EmployersIdentificationNumber).HasColumnType("nvarchar(50)");
			builder.Property(x => x.Address).HasColumnType("nvarchar(80)");
			builder.Property(x => x.City).HasColumnType("nvarchar(50)");
			builder.Property(x => x.State).HasColumnType("nvarchar(2)");
			builder.Property(x => x.Zip).HasColumnType("nvarchar(10)");

			// relations

			builder.HasOne(r => r.Claim);
		}
    }
}
