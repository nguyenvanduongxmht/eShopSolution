using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    class LanguagesConfiguration : IEntityTypeConfiguration<Languages>
    {

        public void Configure(EntityTypeBuilder<Languages> builder)
        {
            builder.ToTable("Languages", "apps"); ;
            builder.HasKey(x => x.Id);
        }
    }
}
