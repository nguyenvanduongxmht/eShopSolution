using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Promotion
    {
        public int Id { get; set; }
        public DateTime Fromdate { get; set; }
        public DateTime Todate { get; set; }
        public int ApplyForAll { get; set; }
        public float DiscountPercent { get; set; }
        public float DiscountAmount { get; set; }
        public int ProductIds { get; set; }
        public int ProductCategoryIds { get; set; }
        public int Status { get; set; }
        public string Name { get; set; }
    }
}
