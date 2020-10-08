using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            if (this.menuItems.Contains(newItem))
            {
                Console.WriteLine("Item already on menu.");
                return;
            }
            this.menuItems.Add(newItem);
        }

        public void RemoveItem(MenuItem deleteItem)
        {
            this.menuItems.Remove(deleteItem);
        }

        public void IsNewItem(MenuItem item)
        {
            if (item.newItem == true)
            {
                Console.WriteLine("The " + item.description + " is new to our menu!");
            } else
            {
                Console.WriteLine("The " + item.description + " is not a new item. It's one of our delicious favorites.");
            }
        }

        public void MenuLastUpdated()
        {
            Console.WriteLine("Our menu was last updated on: " + this.lastUpdated.ToString("d"));
        }

        public void PrintSingleItem(MenuItem item)
        {
            Console.WriteLine("Item Name: " + item.description + "\nItem Price: " + item.price + "\nItem Course: " + item.category +
                "\nDate Added to Menu: " + item.dateAdded.ToString("d"));
        }

        public void PrintMenu()
        {
            Console.WriteLine("Appetizers:\n");
            
            foreach (MenuItem item in this.menuItems) if (item.category == "Appetizer")
            {
                 Console.WriteLine("*****\nItem Name: " + item.description + "\nItem Price: " + item.price + "\n");
            }

            Console.WriteLine("*****\nMain Courses:\n");

            foreach (MenuItem item in this.menuItems) if (item.category == "Main Course")
            {
                  Console.WriteLine("*****\nItem Name: " + item.description + "\nItem Price: " + item.price + "\n");
            }

            Console.Write("*****\nDesserts:\n\n");

            foreach(MenuItem item in this.menuItems) if (item.category == "Dessert")
            {
                  Console.WriteLine("*****\nItem Name: " + item.description + "\nItem Price: " + item.price + "\n");
            }

            Console.WriteLine("Menu last updated: " + this.lastUpdated.ToString("d"));
        }
    }
}
