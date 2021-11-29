using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant_Menu
{
    public class MenuItem
    {
        
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; }

        public MenuItem(double price, string description, string category)
        {
            
            Price = price;
            Description = description;
            Category = category;
            //have IsNew set to true by default
            IsNew = true;
        }

    }
}
