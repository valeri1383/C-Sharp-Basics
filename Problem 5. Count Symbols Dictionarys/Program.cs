using System;
using System.Collections.Generic;

namespace Problem_5._Count_Symbols_Dictionarys
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var dict = new SortedDictionary<char, int>();

            foreach (var item in text)
            {
                if (!dict.ContainsKey(item))
                {
                    dict[item] = 0;
                }
                dict[item]++;
            }

            foreach (var item in dict.Keys)
            {
                Console.WriteLine($"{item}: {dict[item]} time/s");
            }
        }
    }
}
