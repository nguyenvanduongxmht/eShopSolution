using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    class TransactionStatusConfiguration : IEntityTypeConfiguration<TransactionStatus>
    {
        public void Configure(EntityTypeBuilder<TransactionStatus> builder)
        {
            builder.ToTable("TransactionStatus");
            builder.HasKey(x => x.Id);
        }
    }
}
