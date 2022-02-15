using System;
using System.Collections.Generic;

namespace _1._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var symbolsDict = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                char currentSym = text[i];
                if (!symbolsDict.ContainsKey(currentSym) && currentSym.ToString() != " ")
                {
                    symbolsDict[currentSym] = 0;
                }
                if (currentSym.ToString() != " ")
                {
                    symbolsDict[currentSym] += 1;
                }
                
            }

            foreach (var item in symbolsDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
