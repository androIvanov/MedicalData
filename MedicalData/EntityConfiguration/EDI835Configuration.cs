using Microsoft.EntityFrameworkCore;
using MedicalData.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

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

            // relations

            builder.HasMany(r => r.ClaimPayments);

            // seeding 

            //builder.HasData(
            //    new EDI835Message 
            //    {
            //        MessageId = 1,
            //        Message = "Lorem ipsum ziben aleb",
            //        DateAdded = DateTime.UtcNow
            //    }
            //);
        }
    }
}
