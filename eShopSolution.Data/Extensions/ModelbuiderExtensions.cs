using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extensions
{
    public static class ModelbuiderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appconfig>().HasData(
new Appconfig { Key = 1, Value = "Appconfig 1" },
new Appconfig { Key = 2, Value = "Appconfig 2" });

            modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, DateCreate = DateTime.Now, OriginalPrice = 200000, Price = 150000, SeoAlias = "Quần đùi adidas", Stock = 0, ViewCount = 0 },
            new Product { Id = 2, DateCreate = DateTime.Now, OriginalPrice = 200000, Price = 150000, SeoAlias = "Quần âu", Stock = 0, ViewCount = 0 },
            new Product { Id = 3, DateCreate = DateTime.Now, OriginalPrice = 200000, Price = 150000, SeoAlias = "Áo", Stock = 0, ViewCount = 0 }

                );
            modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, IsShowOnHome = true, ParentID = null, SortOder = 1, Status = Enum.Status.Active, Name = "Category 1" },
            new Category { Id = 2, IsShowOnHome = true, ParentID = null, SortOder = 2, Status = Enum.Status.Active, Name = "Category 2" },
            new Category { Id = 3, IsShowOnHome = true, ParentID = null, SortOder = 3, Status = Enum.Status.Active, Name = "Category 3" }
             );

            modelBuilder.Entity<Contact>().HasData(
            new Contact { Email = "nguyenvanduong.xmht@gmail.com", Id = 1, Message = "", Name = "Hà nội", PhoneNumber = "0363296546", Status = Enum.Status.Active },
            new Contact { Email = "xcdfs.xmht@gmail.com", Id = 2, Message = "", Name = "Hải Dương", PhoneNumber = "01232965462", Status = Enum.Status.Active }
            );
            modelBuilder.Entity<Languages>().HasData(
            new Languages { Id = 1, IsDefault = true, Name = "Tiếng việt" },
            new Languages { Id = 2, IsDefault = false, Name = "English" }
            );

            modelBuilder.Entity<ProductInCategories>().HasData(
            new ProductInCategories { CategoryId = 1, ProductId = 1 },
            new ProductInCategories { CategoryId = 1, ProductId = 2 },
            new ProductInCategories { CategoryId = 2, ProductId = 3 },
            new ProductInCategories { CategoryId = 2, ProductId = 1 }
            );
        }
    }
}
