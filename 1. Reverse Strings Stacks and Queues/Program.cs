using System;
using System.Collections.Generic;

namespace _1._Reverse_Strings_Stacks_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var stack = new Stack<string>();

            for (int i = 0; i < text.Length; i++)
            {
                string currentChar = text[i].ToString();
                stack.Push(currentChar);
            }
            Console.WriteLine(string.Join("", stack));
            

        }
    }
}
