using System;

namespace _4._Text_Filter_Text_Processing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0;  j < bannedWords.Length;  j++)
                {
                    int wordLenght = bannedWords[j].Length;
                    string censuredWord = new string('*', wordLenght);
                    if (text.Contains(bannedWords[j]))
                    {
                        text = text.Replace(bannedWords[j], censuredWord);
                    }
                }
            }
            Console.WriteLine(text);
        }
    }
}
