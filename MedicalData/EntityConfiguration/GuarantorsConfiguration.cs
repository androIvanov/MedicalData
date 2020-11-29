using MedicalData.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalData.EntityConfiguration
{
    class GuarantorsConfiguration : IEntityTypeConfiguration<Guarantors>
    {
        public void Configure(EntityTypeBuilder<Guarantors> builder)
        {
            builder.HasKey(k => k.GuarantorId);
			builder.Property(x => x.GuarantorId).HasColumnType("int").IsRequired();
			builder.Property(x => x.AccountId).HasColumnType("int").IsRequired();
			builder.Property(x => x.FamilyName).HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(x => x.GivenName).HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(x => x.MiddleName).HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(x => x.Suffix).HasColumnType("nvarchar(50)").IsRequired();
			builder.Property(x => x.SetID).HasColumnType("nvarchar(50)").IsRequired();
			builder.Property(x => x.StreetAddress).HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(x => x.City).HasColumnType("nvarchar(255)").IsRequired();
			builder.Property(x => x.State).HasColumnType("nvarchar(50)").IsRequired();
			builder.Property(x => x.Zip).HasColumnType("nvarchar(10)").IsRequired();
			builder.Property(x => x.PhoneNumberHome).HasColumnType("nvarchar(50)");
			builder.Property(x => x.PhoneNumberBusiness).HasColumnType("nvarchar(50)");
			builder.Property(x => x.DateOfBirth).HasColumnType("date").IsRequired();
			builder.Property(x => x.Relationship).HasColumnType("nvarchar(10)");
			builder.Property(x => x.SNN).HasColumnType("nvarchar(50)");
			builder.Property(x => x.EmployerName).HasColumnType("nvarchar(255)");
			builder.Property(x => x.EmployerAddress).HasColumnType("nvarchar(255)");
			builder.Property(x => x.EmployerPhoneNumber).HasColumnType("nvarchar(50)");

			// relations

			builder.HasOne(r => r.PatientAccount);
			builder.HasMany(r => r.Insurances);
		}
    }
}
