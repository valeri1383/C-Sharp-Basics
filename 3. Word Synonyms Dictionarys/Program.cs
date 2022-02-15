using System;
using System.Collections.Generic;

namespace _3._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var words = new Dictionary<string, List<string>>();

            for (int i = 0; i < num; i++)
            {
                string currentWord = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!words.ContainsKey(currentWord))
                {
                    words.Add(currentWord, new List<string>());
                }
                words[currentWord].Add(synonym);
            }

            foreach (var item in words)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }

        }
    }
}
