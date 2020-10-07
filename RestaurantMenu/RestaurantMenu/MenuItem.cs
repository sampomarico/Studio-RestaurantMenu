using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class MenuItem
    {
        private double price;
        private string description;
        private string category;
        private DateTime dateAdded = new DateTime();
        private Boolean newItem;

        public MenuItem(double price, string description, string category, DateTime dateAdded, Boolean newItem)
        {
            this.price = price;
            this.description = description;
            this.category = category;
            this.dateAdded = dateAdded;
            this.newItem = newItem;
        }

        public double Price { get; set; }
        public string Description { get; set; }
        public string[] Category { get; set; }
        public DateTime DateAdded { get; set; }
        public Boolean NewItem { get; set; }
    }

}
