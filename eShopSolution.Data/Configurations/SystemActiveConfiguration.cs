﻿using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    class SystemActiveConfiguration : IEntityTypeConfiguration<SystemActivity>
    {
        public void Configure(EntityTypeBuilder<SystemActivity> builder)
        {
            builder.ToTable("SystemActivity");
            builder.HasKey(x => x.Id);
            throw new NotImplementedException();
        }
    }
}
