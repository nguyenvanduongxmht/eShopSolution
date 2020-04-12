using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public float Quantity { get; set; }
        public float Price { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }

    }
}
