using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string token = Console.ReadLine();

            while (token != "end")
            {
                string action = token.Split()[0];
                int element = int.Parse(token.Split()[1]);
                if (action == "Delete")
                {
                    numbers.RemoveAll(x => x == element);
                }
                else if (action == "Insert")
                {
                    int position = int.Parse(token.Split()[2]);
                    numbers.Insert(position, element);
                }

                token = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
