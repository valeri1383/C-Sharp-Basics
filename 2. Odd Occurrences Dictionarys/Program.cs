using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split().ToArray();
            Dictionary<string, int> result = new Dictionary<string, int>();


            foreach (var item in data)
            {
                string wordToLower = item.ToLower();
                if (!result.ContainsKey(wordToLower))
                {
                    result[wordToLower] = 0;
                }
                result[wordToLower]++;
            }

            foreach (var i in result.Keys)
            {
                if (result[i] % 2 == 1)
                {
                    Console.Write($"{i} ");
                }
            }

        }
    }
}
