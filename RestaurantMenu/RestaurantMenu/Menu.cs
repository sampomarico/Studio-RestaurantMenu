using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class Menu
    {
        private List<MenuItem> menuItems;
        private DateTime lastupdated;

        public Menu(List<MenuItem> menuItems)
        {
            this.menuItems = new List<MenuItem>();
        }
    }
}
