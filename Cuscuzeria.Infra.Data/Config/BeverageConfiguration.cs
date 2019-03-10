﻿using Cuscuzeria.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cuscuzeria.Infra.Data.Config
{
    public class BeverageConfiguration : IEntityTypeConfiguration<Beverage>
    {
        public void Configure(EntityTypeBuilder<Beverage> builder)
        {
            //Defines PK
            builder.HasKey(b => b.BeverageId);
            //Defines NOT NULL
            builder.Property(b => b.BeverageName).IsRequired();
            builder.Property(b => b.Description).IsRequired();
            //Defines field Size
            builder.Property(b => b.BeverageName).HasMaxLength(150);
            builder.Property(b => b.Description).HasMaxLength(500);
        }
    }
}
