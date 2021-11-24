using System;

namespace Restaurant_Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuItem Burger = new MenuItem("Burger", 8.49, "Quarter pound burger", "Burgers", true);

            Console.WriteLine(Burger.Price);
        }
    }
}
