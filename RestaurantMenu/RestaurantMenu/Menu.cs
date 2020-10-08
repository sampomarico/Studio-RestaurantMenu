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

        public string IsNewItem(MenuItem item)
        {
            if (item.newItem == true)
            {
                return "The " + item.description + " is new to our menu!";
            } else
            {
                return "The " + item.description + " is not a new item. It's one of our delicious favorites.";
            }
        }

        public string MenuLastUpdated(Menu menu)
        {
            return "Our menu was last updated on: " + menu.lastUpdated;
        }

        public string PrintSingleItem(MenuItem item)
        {
            return "Item Name: " + item.description + "\nItem Price: " + item.price + "\nItem Course: " + item.category +
                "\nDate Added to Menu: " + item.dateAdded.ToString("d");
        }
    }
}
