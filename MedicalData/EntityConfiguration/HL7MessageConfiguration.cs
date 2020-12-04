using Microsoft.EntityFrameworkCore;
using MedicalData.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalData.EntityConfiguration
{
    class HL7MessageConfiguration : IEntityTypeConfiguration<HL7Messages>
    {
        public void Configure(EntityTypeBuilder<HL7Messages> builder)
        {
            builder.HasNoKey();
            builder.Property(x => x.MessageDateTime).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.Message).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(x => x.AccountId).HasColumnType("int").IsRequired();
        }
    }
}
