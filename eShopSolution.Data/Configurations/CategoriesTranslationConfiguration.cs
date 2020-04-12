using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    class CategoriesTranslationConfiguration : IEntityTypeConfiguration<CategoriesTranslation>
    {
        public void Configure(EntityTypeBuilder<CategoriesTranslation> builder)
        {
            builder.ToTable("CategoriesTranslations");
            builder.HasKey(x => x.Id);
            builder
            .HasOne<Category>(s => s.Category)
            .WithMany(g => g.CategoriesTranslations)
            .HasForeignKey(s => s.CategoryId);
        }
    }
}
