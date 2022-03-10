using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Count_Same_Values_in_Array_Sets_and_Nested_Dict
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().ToArray();
            var dict = new Dictionary<string, int>();

            foreach (var item in numbers)
            {
                if (!dict.ContainsKey(item))
                {
                    dict[item] = 0;
                }
                dict[item]++;

            }

            foreach (var num in dict.Keys)
            {
                Console.WriteLine($"{num} - {dict[num]} times");
            }
        }
    }
}
