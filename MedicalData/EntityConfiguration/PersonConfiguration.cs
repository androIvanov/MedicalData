using Microsoft.EntityFrameworkCore;
using MedicalData.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalData.EntityConfiguration
{
    class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(k => k.Id);
			builder.Property(x => x.Id).HasColumnType("int").IsRequired();
			builder.Property(x => x.PatientIdExt).HasColumnType("nvarchar(50)").IsRequired();
			builder.Property(x => x.MRN).HasColumnType("nvarchar(50)").IsRequired();
			builder.Property(x => x.PatientId).HasColumnType("nvarchar(50)").IsRequired();
			builder.Property(x => x.FamilyName).HasColumnType("nchar(255)").IsRequired();
			builder.Property(x => x.GivenName).HasColumnType("nchar(255)").IsRequired();
			builder.Property(x => x.MiddleName).HasColumnType("nchar(255)").IsRequired();
			builder.Property(x => x.NameSuffix).HasColumnType("nchar(255)").IsRequired();
			builder.Property(x => x.MothersMaidenName).HasColumnType("nchar(255)").IsRequired();
			builder.Property(x => x.DateOfBirth).HasColumnType("date").IsRequired();
			builder.Property(x => x.Sex).HasColumnType("varchar(1)").IsRequired();
			builder.Property(x => x.Race).HasColumnType("nvarchar(50)");
			builder.Property(x => x.StreetAddress).HasColumnType("nchar(255)").IsRequired();
			builder.Property(x => x.OtherDesignation).HasColumnType("nchar(255)").IsRequired();
			builder.Property(x => x.City).HasColumnType("nchar(10)").IsRequired();
			builder.Property(x => x.State).HasColumnType("nchar(10)").IsRequired();
			builder.Property(x => x.Zip).HasColumnType("nchar(10)").IsRequired();
			builder.Property(x => x.Country).HasColumnType("nchar(10)");
			builder.Property(x => x.PhoneHome).HasColumnType("nchar(10)");
			builder.Property(x => x.PhoneBusiness).HasColumnType("nchar(10)");
			builder.Property(x => x.Language).HasColumnType("nchar(10)");
			builder.Property(x => x.SNN).HasColumnType("nchar(10)").IsRequired();
			builder.Property(x => x.DriversLicense).HasColumnType("nchar(10)");
			builder.Property(x => x.BirthOrder).HasColumnType("int");
			builder.Property(x => x.Citizenship).HasColumnType("nchar(10)");
			builder.Property(x => x.PatientDeathDate).HasColumnType("datetime");
			builder.Property(x => x.PatientDeathIndicator).HasColumnType("int");

			// relations 

			builder.HasMany(r => r.PatientAccounts);
		}
    }
}
