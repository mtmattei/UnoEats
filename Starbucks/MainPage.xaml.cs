using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.UI.Xaml.Controls;

namespace Starbucks
{ 
    public sealed partial class MainPage : Page
    {
        // Observable collections for binding
        public ObservableCollection<CategoryItem> Categories { get; } = new ObservableCollection<CategoryItem>();
        public ObservableCollection<StoreItem> Stores { get; } = new ObservableCollection<StoreItem>();
        public ObservableCollection<RestaurantItem> Restaurants { get; } = new ObservableCollection<RestaurantItem>();

        public MainPage()
        {
            this.InitializeComponent();

            // Load sample data
            LoadSampleData();
        }

        // Helper methods for filtered restaurant lists
        public IEnumerable<RestaurantItem> GetOrderAgainRestaurants()
        {
            // Return the first 2 restaurants for the "Order Again" section
            return Restaurants.Take(2);
        }

        public IEnumerable<RestaurantItem> GetBestRatedRestaurants()
        {
            // Return top rated restaurants for the "Best Overall" section
            // In a real app, you would sort by rating and return the highest rated ones
            return Restaurants.Skip(2).Take(2);
        }

        private void LoadSampleData()
        {
            // Add categories
            Categories.Add(new CategoryItem { Name = "Grocery", IconSource = "ms-appx:///Assets/Images/grocery.png" });
            Categories.Add(new CategoryItem { Name = "Pizza", IconSource = "ms-appx:///Assets/Images/pizza.png" });
            Categories.Add(new CategoryItem { Name = "Sushi", IconSource = "ms-appx:///Assets/Images/sushi.png" });
            Categories.Add(new CategoryItem { Name = "Fast Food", IconSource = "ms-appx:///Assets/Images/fastfood.png" });
            Categories.Add(new CategoryItem { Name = "Alcohol", IconSource = "ms-appx:///Assets/Images/alcohol.png" });
            Categories.Add(new CategoryItem { Name = "Burgers", IconSource = "ms-appx:///Assets/Images/burger.png" });
            Categories.Add(new CategoryItem { Name = "Convenience", IconSource = "ms-appx:///Assets/Images/convenience.png" });

            // Add stores
            Stores.Add(new StoreItem { Name = "IGA", LogoSource = "ms-appx:///Assets/Images/iga.png", DeliveryTime = "25 min", IsFastDelivery = false });
            Stores.Add(new StoreItem { Name = "Costco", LogoSource = "ms-appx:///Assets/Images/costco.jpg", DeliveryTime = "60 min", IsFastDelivery = false });
            Stores.Add(new StoreItem { Name = "Super C", LogoSource = "ms-appx:///Assets/Images/superc.jpg", DeliveryTime = "50 min", IsFastDelivery = false });
            Stores.Add(new StoreItem { Name = "Metro", LogoSource = "ms-appx:///Assets/Images/metro.png", DeliveryTime = "35 min", IsFastDelivery = false });
            Stores.Add(new StoreItem { Name = "Walmart", LogoSource = "ms-appx:///Assets/Images/walmart.jpg", DeliveryTime = "45 min", IsFastDelivery = false });
            Stores.Add(new StoreItem { Name = "Jean Coutu", LogoSource = "ms-appx:///Assets/Images/jeancoutu.png", DeliveryTime = "20 min", IsFastDelivery = true });

            // Add restaurants
            Restaurants.Add(new RestaurantItem
            {
                Name = "K-BROS Restaurant Coréen",
                ImageSource = "ms-appx:///Assets/Images/kbros.jpeg",
                DeliveryFee = "$0.99 Delivery Fee",
                Rating = "4.8★",
                ReviewCount = "(1,500+)",
                DeliveryTime = "20 min",
                HasPromotion = false,
                HasPriority = false
            });

            Restaurants.Add(new RestaurantItem
            {
                Name = "Starbucks",
                ImageSource = "ms-appx:///Assets/Images/starbucks.jpeg",
                DeliveryFee = "$3.99 Delivery Fee",
                Rating = "4.7★",
                ReviewCount = "(2,000+)",
                DeliveryTime = "15 min",
                HasPromotion = true,
                PromotionText = "35% off (Spend CA$25)",
                HasPriority = true
            });

            Restaurants.Add(new RestaurantItem
            {
                Name = "Restaurant Imperial",
                ImageSource = "ms-appx:///Assets/Images/imperial.jpeg",
                DeliveryFee = "$0 Delivery Fee",
                Rating = "4.6★",
                ReviewCount = "(1,000+)",
                DeliveryTime = "20 min",
                HasPromotion = true,
                PromotionText = "CA$0 Delivery Fee (Spend CA$15)",
                HasPriority = false
            });

            Restaurants.Add(new RestaurantItem
            {
                Name = "McDonald's",
                ImageSource = "ms-appx:///Assets/Images/mcdonalds.jpeg",
                DeliveryFee = "$4.49 Delivery Fee",
                Rating = "4.3★",
                ReviewCount = "(6,000+)",
                DeliveryTime = "10 min",
                HasPromotion = true,
                PromotionText = "Buy 1, Get 1 Free",
                HasPriority = true
            });
        }
    }
}
