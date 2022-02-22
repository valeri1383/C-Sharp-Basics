using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._Repeat_Strings_Text_Processing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            StringBuilder result = new StringBuilder();

            foreach (var word in words)
            {
                int count = word.Length;
                for (int i = 0; i < count; i++)
                {
                    result.Append(word);
                }
            }

            Console.WriteLine(result);
        }
    }
}
