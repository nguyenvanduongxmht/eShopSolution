using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace eShopSolution.Data.EF
{
    class EShopDbContextFactory : IDesignTimeDbContextFactory<EShopDbContext>
    {
        public EShopDbContext CreateDbContext(string[] args)
        {
            // add packages Microsoft.Extensions.Configuration.FileExtensions
            //Microsoft.Extensions.Configuration.Json


            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            var conectionString = configuration.GetConnectionString("EShopSolutionDbLocal");

            var optionsBuilder = new DbContextOptionsBuilder<EShopDbContext>();
            optionsBuilder.UseSqlServer(conectionString);
            return new EShopDbContext(optionsBuilder.Options);
        }
    }
}
