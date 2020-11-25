using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MedicalData.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalData.EntityConfiguration
{
    class PtdScoreConfiguration : IEntityTypeConfiguration<PtdScore>
    {
        public void Configure(EntityTypeBuilder<PtdScore> builder)
        {
            builder.HasKey(k => k.ScoreId);
            builder.Property(x => x.ScoreId).HasColumnType("int");
            builder.Property(x => x.AccountId).HasColumnType("int");
            builder.Property(x => x.Code).HasColumnType("nvarchar(50)");
            builder.Property(x => x.Score).HasColumnType("decimal(18, 2)");
            builder.Property(x => x.IsResolved).HasColumnType("bit");
            builder.Property(x => x.Notes).HasColumnType("nvarchar(255)");
            builder.Property(x => x.ResolvedBy).HasColumnType("nchar(10)");
            builder.Property(x => x.ResolvedDate).HasColumnType("datetime");
        }
    }
}
