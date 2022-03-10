using System;
using System.Collections.Generic;

namespace Problem_6._Wardrobe_Dictionarys
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var clothes = Console.ReadLine().Split(" -> ");
                string color = clothes[0];
                var token = clothes[1].Split(",");

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }
                foreach (var item in token)
                {
                    if (!wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color][item] = 0;
                    }
                    wardrobe[color][item]++;
                }
            }

            var searchedItems = Console.ReadLine().Split();
            string searchedColor = searchedItems[0];
            string searchedItem = searchedItems[1];

            foreach (var color in wardrobe.Keys)
            {
                Console.WriteLine($"{color} clothes:");

                foreach (var item in wardrobe[color].Keys)
                {
                    if (color == searchedColor && item == searchedItem)
                    {
                        Console.WriteLine($"* {item} - {wardrobe[color][item]} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item} - {wardrobe[color][item]}");
                    }
                    
                }
            }
        }
    }
}
