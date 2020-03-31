using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategories>
    {
        public void Configure(EntityTypeBuilder<ProductInCategories> builder)
        {
            builder.ToTable("ProductInCategories");
            builder.HasKey(x => new { x.CategoryId, x.ProductId });

            builder.HasOne(x => x.Product).WithMany(b => b.ProductInCategories).HasForeignKey(bc => bc.ProductId); ;
            builder.HasOne(x => x.Category).WithMany(b => b.ProductInCategories).HasForeignKey(bc => bc.CategoryId); ;
            builder.HasOne(x => x.Category).WithMany(b => b.ProductInCategories).HasForeignKey(bc => bc.CategoryId); ;




        }
    }
}
