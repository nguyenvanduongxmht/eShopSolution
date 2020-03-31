using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class AppconfigConfiguration : IEntityTypeConfiguration<Appconfig>
    {
        void IEntityTypeConfiguration<Appconfig>.Configure(EntityTypeBuilder<Appconfig> builder)
        {
            builder.ToTable("Appconfigs");
            builder.HasKey(x => x.Key);
            builder.Property(t => t.Key).IsRequired();
        }
    }
}
