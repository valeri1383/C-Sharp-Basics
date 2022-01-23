using System;
using System.Collections.Generic;

namespace _4._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<string> productsList = new List<string>();

            for (int i = 0; i < num; i++)
            {
                string product = Console.ReadLine();
                productsList.Add(product);
            }

            productsList.Sort();

            for (int i = 0; i < productsList.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{productsList[i]}");
            }
        }
    }
}
