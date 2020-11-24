using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MedicalData.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalData.EntityConfiguration
{
    class EDI835Configuration : IEntityTypeConfiguration<EDI835Message>
    {
        public void Configure(EntityTypeBuilder<EDI835Message> builder)
        {
            builder.HasKey(k => k.MessageId);
            builder.Property(p => p.MessageId).HasColumnType("int").IsRequired();
            builder.Property(p => p.Message).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(p => p.DateAdded).HasColumnType("datetime").IsRequired();
        }
    }
}
