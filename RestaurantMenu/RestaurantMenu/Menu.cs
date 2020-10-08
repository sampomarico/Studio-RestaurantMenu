using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace RestaurantMenu
{
    class Menu
    {
        public List<MenuItem> menuItems { get; set; }
        public DateTime lastUpdated { get; set; }

       public Menu(List<MenuItem> item)
        {
            this.menuItems = item;
            this.lastUpdated = DateTime.Now;
        }

        public void AddItem(MenuItem newItem)
        {
            this.menuItems.Add(newItem);
        }

        public void RemoveItem(MenuItem deleteItem)
        {
            this.menuItems.Remove(deleteItem);
        }
    }
}
