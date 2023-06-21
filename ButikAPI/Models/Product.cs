﻿namespace ButikAPI.Models
{
    public class Product: BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public int BranchId { get; set; }
    }
}
