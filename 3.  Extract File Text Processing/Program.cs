using System;

namespace _3.__Extract_File_Text_Processing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split("\\");
            string token = text[text.Length - 1];
            string file = token.Split(".")[0];
            string extention = token.Split(".")[1];
            Console.WriteLine($"File name: {file}");
            Console.WriteLine($"File extension: {extention}");
        }
    }
}
