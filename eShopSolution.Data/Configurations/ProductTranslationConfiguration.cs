using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    class ProductTranslationConfiguration: IEntityTypeConfiguration<ProductTranslation>
    {
        public void Configure(EntityTypeBuilder<ProductTranslation> builder)
        {
            builder.ToTable("ProductTranslation");
            builder.HasKey(x => x.ID);
            builder.HasOne<Product>(x => x.Product)
                    .WithMany(p => p.ProductTranslations)
                    .HasForeignKey(p => p.ProductID);
        }
    }
}
