using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetails");
            builder.HasKey(x => new { x.OrderId, x.ProductId });
            
            builder.HasOne(c => c.Product).WithMany(e => e.OrderDetails).HasForeignKey(x => x.ProductId);
            builder
                       .HasOne<Order>(s => s.Order)
                       .WithMany(g => g.OrderDetails)
                       .HasForeignKey(s => s.OrderId);
            builder.HasOne<Product>(p => p.Product)
                        .WithMany(x => x.OrderDetails)
                        .HasForeignKey(x => x.ProductId);
            }
    }
}
