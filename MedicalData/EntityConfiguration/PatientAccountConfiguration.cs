using System;
using System.Collections.Generic;
using System.Text;
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
        }
    }
}
