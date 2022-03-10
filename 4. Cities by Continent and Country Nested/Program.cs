using System;
using System.Collections.Generic;

namespace _4._Cities_by_Continent_and_Country_Nested
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                var token = Console.ReadLine().Split();
                string continent = token[0];
                string countrie = token[1];
                string city = token[2];
                if (!dict.ContainsKey(continent))
                {
                    dict[continent] = new Dictionary<string, List<string>>();
                }
                if (!dict[continent].ContainsKey(countrie))
                {
                    dict[continent][countrie] = new List<string>();
                }
                dict[continent][countrie].Add(city);
            }

            foreach (var item in dict.Keys)
            {
                Console.WriteLine($"{item}:");
                foreach (var el in dict[item].Keys)
                {
                    Console.WriteLine($"{el} -> {string.Join(", ", dict[item][el])}");
                }
            }
        }
    }
}
