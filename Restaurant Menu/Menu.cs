using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant_Menu
{
    public class Menu
    {
        public string Title { get; set; }
        public List<MenuItem> Items { get; set; }
        public DateTime LastUpdated { get; set; }

        public Menu(string title)
        {
            Title = title;
            // initialize Items to be an empty list of menu items upon creating a Menu,
            // then from there, we can add menu items in after the fact
            Items = new List<MenuItem>();
            // set last updated to be today's date
            // can use DateTime.Today or DateTime.Now
            LastUpdated = DateTime.Now;
        }
        //add a menu item to the menu
        public void AddItem(MenuItem item)
        {
            Items.Add(item);
        }

        public void PrintMenu() 
        { 
            foreach (MenuItem item in Items)
            {
                Console.WriteLine(item.Description);
            }
        }
    }
}
