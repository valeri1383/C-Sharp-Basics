using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<double>> menu = new Dictionary<string, List<double>>();

            while (command != "buy")
            {
                string item = command.Split()[0];
                double price = double.Parse(command.Split()[1]);
                int quantity = int.Parse(command.Split()[2]);
                if (!menu.ContainsKey(item))
                {
                    menu[item] = new List<double> { price, quantity };
                }
                else if (menu.ContainsKey(item))
                {
                    menu[item][0] = price;
                    menu[item][1] += quantity;
                }
                
                command = Console.ReadLine();
            }

            foreach (var item in menu.Keys)
            {
                Console.WriteLine($"{item} -> {menu[item][0] * menu[item][1]:F2}");
            }
        }
    }
}
