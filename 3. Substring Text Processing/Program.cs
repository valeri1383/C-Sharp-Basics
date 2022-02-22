using System;

namespace _3._Substring_Text_Processing
{
    class Program
    {
        static void Main(string[] args)
        {
            string textToRemove = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(textToRemove))
            {
                int indexToremove = text.IndexOf(textToRemove);
                text = text.Remove(indexToremove, textToRemove.Length);

            }
            Console.WriteLine(text);
        }
    }
}
