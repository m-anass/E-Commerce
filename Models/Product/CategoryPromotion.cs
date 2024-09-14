﻿namespace E_Commerce.Models.Product
{
    public class CategoryPromotion
    {
        [ForeignKey("ProductCategories")]
        public int CategoryId { get; set; }

        public int PromotionId { get; set; }

        public ProductCategories ProductCategories { get; set; }
        public Promotion Promotion { get; set; }
    }
}
