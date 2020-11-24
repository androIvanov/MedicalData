using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MedicalData.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalData.EntityConfiguration
{
    class NextOfKinConfiguration : IEntityTypeConfiguration<NextOfKin>
    {
        public void Configure(EntityTypeBuilder<NextOfKin> builder)
        {
            builder.HasKey(k => k.NOKId);
            builder.Property(x => x.NOKId).HasColumnType("int").IsRequired();
            builder.Property(x => x.AccountId).HasColumnType("int").IsRequired();
            builder.Property(x => x.SetID).HasColumnType("nchar(255)").IsRequired();
            builder.Property(x => x.Name).HasColumnType("nchar(255)").IsRequired();
            builder.Property(x => x.Relationship).HasColumnType("nchar(255)").IsRequired();
            builder.Property(x => x.Address).HasColumnType("nchar(255)").IsRequired();
            builder.Property(x => x.PhoneHome).HasColumnType("nchar(255)").IsRequired();
            builder.Property(x => x.PhoneBusiness).HasColumnType("nchar(255)").IsRequired();
        }
    }
}
