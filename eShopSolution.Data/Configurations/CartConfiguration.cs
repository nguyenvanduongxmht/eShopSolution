using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        void IEntityTypeConfiguration<Cart>.Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Carts");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ProductId).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Price).IsRequired().HasValueGenerator(8);
            throw new NotImplementedException();
        }

    }
}
