﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalData.EntityConfiguration
{
    class CallsToActionConfiguration : IEntityTypeConfiguration<CallsToActions>
    {

        public void Configure(EntityTypeBuilder<CallsToActions> builder)
        {
            builder.HasKey(p => p.Code);
            builder.Property(p => p.Code).IsRequired().HasColumnType("nvarchar(50)");
            builder.Property(p => p.PtdCoeficient).IsRequired().HasColumnType("int");
            builder.Property(p => p.Action1).HasColumnType("nvarchar(255)");
            builder.Property(p => p.Action2).HasColumnType("nvarchar(255)");
        }
    }
}
