using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class Restaurant
    {
        static void Main(string[] args)
        {
            MenuItem fillet = new MenuItem("$29.99", "Steak", "dinner", DateTime.Now, true);
            MenuItem bakedPotato = new MenuItem("$6.99", "Baked Potato", "appetizer", DateTime.Now, true);
            MenuItem iceCream = new MenuItem("$4.99", "Ice Cream Sundea", "dessert", DateTime.Now, false);
            List<MenuItem> items = new List<MenuItem> { fillet, bakedPotato, iceCream };
            Menu dinnerMenu = new Menu(items);

            foreach (MenuItem item in dinnerMenu.menuItems)
            {
                Console.WriteLine(item.description + ", " + item.price + ", " + item.dateAdded + ", " + item.newItem);
            }


           
            
        
        
        }
    }
}
