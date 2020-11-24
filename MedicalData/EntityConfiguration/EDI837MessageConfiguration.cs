using System;
using System.Collections.Generic;
using System.Text;
using MedicalData.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalData.EntityConfiguration
{
    class EDI837MessageConfiguration : IEntityTypeConfiguration<EDI837Message>
    {
        public void Configure(EntityTypeBuilder<EDI837Message> builder)
        {
            builder.HasKey(k => k.MessageId);
            builder.Property(p => p.MessageId).HasColumnType("int").IsRequired();
            builder.Property(p => p.Message).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(p => p.DateAdded).HasColumnType("datetime").IsRequired();
        }
    }
}
