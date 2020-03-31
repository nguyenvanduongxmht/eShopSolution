using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        void IEntityTypeConfiguration<Cart>.Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Appconfigs");
            builder.HasKey(x => x.ID);
            throw new NotImplementedException();
        }
    }
}
