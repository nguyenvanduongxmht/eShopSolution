using eShopSolution.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class ProductInCart
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CartId { get; set; }
        public Cart Cart { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime UpdateDate { get; set; }
        public Status Status { get; set; }
    }
}
