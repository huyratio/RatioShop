﻿namespace RatioShop.Data.Models
{
    public class ProductCategory
    {        
        public Guid ProductId { get; set; }
        public Product? Product { get; set; }        
        public int CategoryId { get; set; }
        public Category? Category{ get; set; }

    }
}