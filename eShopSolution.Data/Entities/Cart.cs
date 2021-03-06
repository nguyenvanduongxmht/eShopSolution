﻿using eShopSolution.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Cart
    {
        public int ID { get; set; }
        
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime UpdateDate { get; set; }
        public Status Status { get; set; }
        public List<ProductInCart> ProductInCarts { get; set; }
        

    }
}
