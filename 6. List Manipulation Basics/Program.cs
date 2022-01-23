using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string token = Console.ReadLine();

            while (token != "end")
            {
                string command = token.Split()[0];


                if (command == "Add")
                {
                    int num = int.Parse(token.Split()[1]);
                    numbers.Add(num);
                }
                else if (command == "Remove")
                {
                    int num = int.Parse(token.Split()[1]);
                    numbers.Remove(num);
                }
                else if (command == "RemoveAt")
                {
                    int num = int.Parse(token.Split()[1]);
                    numbers.RemoveAt(num);
                }
                else if (command == "Insert")
                {
                    int num = int.Parse(token.Split()[0]);
                    int index = int.Parse(token.Split()[1]);
                    numbers.Insert(index, num);
                }

                token = Console.ReadLine();
            }

        Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
