using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class MenuItem
    {
        public string price { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public DateTime dateAdded { get; set; }
        public Boolean newItem { get; set; }

        public MenuItem(string price, string description, string category, DateTime dateAdded, Boolean newItem)
        {
            this.price = price;
            this.description = description;
            this.category = category;
            this.dateAdded = dateAdded;
            this.newItem = newItem;
        }

    }

}
