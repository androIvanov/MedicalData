using Microsoft.EntityFrameworkCore;
using MedicalData.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalData.EntityConfiguration
{
    class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(k => k.PatientId);
			builder.Property(x => x.PatientId).HasColumnType("int").IsRequired();
			builder.Property(x => x.SubscriberId).HasColumnType("int").IsRequired();
			builder.Property(x => x.EntityTypeQualifier).HasColumnType("nchar(1)");
			builder.Property(x => x.NameLast).HasColumnType("nvarchar(50)");
			builder.Property(x => x.NameFirst).HasColumnType("nvarchar(50)");
			builder.Property(x => x.NameMidle).HasColumnType("nvarchar(50)");
			builder.Property(x => x.NamePrefix).HasColumnType("nvarchar(10)");
			builder.Property(x => x.NameSuffix).HasColumnType("nvarchar(10)");
			builder.Property(x => x.DateOfBirth).HasColumnType("date").IsRequired();
			builder.Property(x => x.Sex).HasColumnType("nchar(1)").IsRequired();
			builder.Property(x => x.Address).HasColumnType("nvarchar(80)");
			builder.Property(x => x.City).HasColumnType("nvarchar(50)");
			builder.Property(x => x.State).HasColumnType("nvarchar(2)");
			builder.Property(x => x.ZIp).HasColumnType("nvarchar(10)");
			builder.Property(x => x.IndividualRelationshipCode).HasColumnType("nvarchar(2)").IsRequired();

			// realtions 

			builder.HasOne(r => r.Subscriber);
		}
    }
}
