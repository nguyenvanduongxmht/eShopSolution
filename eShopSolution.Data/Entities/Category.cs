﻿using eShopSolution.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
   public class Category
    {
        public int Id { get; set; }
        public int SortOder { get; set; }
        public bool IsShowOnHome { get; set; }
        public int? ParentID { get; set; }
        public string Name { get; set; }
        public Status Status {get;set;}
        public List<ProductInCategories>    ProductInCategories { get; set; }
        public List<CategoriesTranslation> CategoriesTranslations { get; set; }

    }
}
