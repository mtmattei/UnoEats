using System;
using System.Collections.Generic;

namespace Starbucks
{
    // Category item model
    public class CategoryItem
    {
        public string Name { get; set; }
        public string IconSource { get; set; }
    }

    // Store item model
    public class StoreItem
    {
        public string Name { get; set; }
        public string LogoSource { get; set; }
        public string DeliveryTime { get; set; }
        public bool IsFastDelivery { get; set; }
    }

    // Restaurant item model
    public class RestaurantItem
    {
        public string Name { get; set; }
        public string ImageSource { get; set; }
        public string DeliveryFee { get; set; }
        public string Rating { get; set; }
        public string ReviewCount { get; set; }
        public string DeliveryTime { get; set; }
        public bool HasPromotion { get; set; }
        public string PromotionText { get; set; }
        public bool HasPriority { get; set; }
    }
}
