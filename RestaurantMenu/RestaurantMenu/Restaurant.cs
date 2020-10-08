using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class Restaurant
    {
        static void Main(string[] args)
        {
            MenuItem fillet = new MenuItem("$29.99", "Steak", "Main Course", new DateTime(2020, 9, 25), true);
            MenuItem roastChicken = new MenuItem("$19.99", "Roast Chicken", "Main Course", new DateTime(2016, 8, 26), false);
            MenuItem bakedPotato = new MenuItem("$6.99", "Baked Potato", "Appetizer", new DateTime(2020, 5, 1), true);
            MenuItem houseSalad = new MenuItem("$8.99", "House Salad", "Appetizer", new DateTime(2013, 1, 1), false);
            MenuItem iceCream = new MenuItem("$4.99", "Ice Cream Sundae", "Dessert", new DateTime(2013, 1, 1), false);
            MenuItem cremeBrulee = new MenuItem("$5.99", "Creme Brulee", "Dessert", new DateTime(2020, 10, 1), true);
            List<MenuItem> items = new List<MenuItem> { fillet, bakedPotato, iceCream, roastChicken, houseSalad, cremeBrulee };
            Menu dinnerMenu = new Menu(items);

            //Print Entire Menu
            //dinnerMenu.PrintMenu();

            //Print Individual Item
                //dinnerMenu.PrintSingleItem(cremeBrulee);
            
            
           //Remove Item and the Print Menu
                //dinnerMenu.RemoveItem(bakedPotato);
                //dinnerMenu.PrintMenu();

            


           
            
        
        
        }
    }
}
