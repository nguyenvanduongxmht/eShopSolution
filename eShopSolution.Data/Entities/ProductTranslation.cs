using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class ProductTranslation
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public string name { get; set; }
        public string Description { get; set; }
        public  string Detail { get; set; }
        public string SeoDescription  { get; set; }
        public string SeoTitle { get; set; }
        public  int  LangueId { get; set; }


    }
}

