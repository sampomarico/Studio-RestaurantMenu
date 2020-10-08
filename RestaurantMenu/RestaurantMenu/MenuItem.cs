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

        public override bool Equals(Object obj)
        {
            if (obj == this)
            {
                return true;
            }
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            MenuItem item = obj as MenuItem;
            return item.description == description;
        }

    }

}
