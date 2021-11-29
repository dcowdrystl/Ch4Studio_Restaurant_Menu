using System;

namespace Restaurant_Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu("Test Menu");
            Console.WriteLine(menu.Title);
            Console.WriteLine(menu.Items);
            Console.WriteLine(menu.Items.Count);
            Console.WriteLine(menu.LastUpdated);

            MenuItem Burger = new MenuItem(8.49, "Quarter pound burger", "Main Course");

            Console.WriteLine(Burger.Price);
            Console.WriteLine(Burger.Description);
            Console.WriteLine(Burger.Category);
            Console.WriteLine();
            MenuItem pumpkinPie = new MenuItem(5.67, "Slice of pumpkin pie", "dessert");
            //add burger item onto our menu
            /*menu.Items.Add(Burger);*/
            menu.AddItem(Burger);
            menu.AddItem(pumpkinPie);
            /*Console.WriteLine(menu.Items.Count);*/
            menu.PrintMenu();

            Console.WriteLine();
            menu.RemoveItem(Burger);
            menu.PrintMenu();

            Burger.IsItNew();

            menu.CheckLastUpdate(); 

            menu.PrintItem(menu.Items[0]);

            menu.PrintMenu();
        }
    }
}
