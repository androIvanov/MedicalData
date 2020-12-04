using Microsoft.EntityFrameworkCore;
using MedicalData.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalData.EntityConfiguration
{
    class PatientAccountConfiguration : IEntityTypeConfiguration<PatientAccount>
    {
        public void Configure(EntityTypeBuilder<PatientAccount> builder)
        {
            builder.HasKey(k => k.AccountId);
            builder.Property(x => x.AccountId).HasColumnType("int").IsRequired();
            builder.Property(x => x.PersonId).HasColumnType("int").IsRequired();
            builder.Property(x => x.AppointmentID).HasColumnType("nchar(10)");
	        builder.Property(x => x.PatientAccountNumber).HasColumnType("nchar(255)").IsRequired();
            builder.Property(x => x.PrimaryCareProvider).HasColumnType("nvarchar(255)");
	        builder.Property(x => x.StudentIndicator).HasColumnType("bit").IsRequired();
            builder.Property(x => x.Facility).HasColumnType("nvarchar(255)").IsRequired();

            // relations 

            builder.HasOne(r => r.Person);
            builder.HasMany(r => r.Diagnoses);
            builder.HasMany(r => r.NextOfKins);
            builder.HasMany(r => r.PtdScores);
            builder.HasMany(r => r.Visits);
            builder.HasMany(r => r.Guarantors);

            // seeding 

            //builder.HasData(
            //    new PatientAccount 
            //    {
            //        AccountId = 1,
            //        PersonId = 1,
            //        AppointmentID = "SSD",
            //        PatientAccountNumber = "J7A1R3V4A9N",
            //        StudentIndicator = false,
            //        Facility = "SoftServe"
            //    }
            //);
        }
    }
}
