using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    class ProductInCartConfiguration : IEntityTypeConfiguration<ProductInCart>
    {
        public void Configure(EntityTypeBuilder<ProductInCart> builder)
        {
            builder.ToTable("ProductInCarts");
            builder.HasKey(sc => new { sc.ProductId, sc.CartId });

            builder
                .HasOne<Product>(PIC => PIC.Product)
                .WithMany(P => P.ProductInCarts)
                .HasForeignKey(PIC => PIC.ProductId);


            builder
                .HasOne<Cart>(PIC => PIC.Cart)
                .WithMany(C => C.ProductInCarts)
                .HasForeignKey(PIC => PIC.CartId);
        }
    }
}
