using System;
using System.Collections.Generic;

namespace _6.__Replace_Repeating_Chars_Text_Processing
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int length = text.Length;
            List<string> result = new List<string>();

            for (int i = 0; i < length; i++)
            {
                
                string currentSymbol = text[i].ToString();
                if (i + 1 == length)
                {
                    if (text[text.Length - 1].ToString() != currentSymbol)
                    {
                        result.Add(currentSymbol);
                    }
                    
                    continue;
                }
                string nextSymbol = text[i + 1].ToString();
                if (!result.Contains(currentSymbol))
                {
                    result.Add(currentSymbol);
                }
                if (nextSymbol != currentSymbol)
                {
                    result.Add(nextSymbol);
                }
            }
            Console.WriteLine(string.Join("", result));
        }
    }
}
