using System;
using System.Collections.Generic;

namespace _3._Product_Shop_Nested_Dict
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            var dict = new SortedDictionary<string, Dictionary<string, double>>();

            while (command != "Revision")
            {
                var token = command.Split(", ");
                string shop = token[0];
                string product = token[1];
                double price = double.Parse(token[2]);
                if (!dict.ContainsKey(shop))
                {
                    dict[shop] = new Dictionary<string, double>();
                }
                if (!dict[shop].ContainsKey(product))
                {
                    dict[shop][product] = 0;
                }
                dict[shop][product] = price;

                command = Console.ReadLine();
            }

            foreach (var item in dict.Keys)
            {
                Console.WriteLine($"{item}->");
                foreach (var el in dict[item].Keys)
                {
                    Console.WriteLine($"Product: {el}, Price: {dict[item][el.ToString()]}");
                }
            }
        }

    }
}
