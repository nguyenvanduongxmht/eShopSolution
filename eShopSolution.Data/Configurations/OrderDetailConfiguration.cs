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
            builder.ToTable("OrderDetails", "apps"); ;
            builder.HasKey(x => new { x.OrderId, x.ProductId });
            builder.HasOne(c => c.Order).WithMany(e => e.OrderDetails).HasForeignKey(x => x.OrderId);
            builder.HasOne(c => c.Product).WithMany(e => e.OrderDetails).HasForeignKey(x => x.ProductId);

        }
    }
}
