using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum_Stacks_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numbers = new Stack<int>(text);
            int total = 0;

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string action = command.Split()[0];

                if (action == "add")
                {
                    int num1 = int.Parse(command.Split()[1]);
                    int num2 = int.Parse(command.Split()[2]);
                    numbers.Push(num1);
                    numbers.Push(num2);
                }

                else if (action == "remove")
                {
                    int num = int.Parse(command.Split()[1]);
                    if (numbers.Count >= num)
                    {
                        for (int i = 0; i < num; i++) numbers.Pop();
                    }
                }

                command = Console.ReadLine().ToLower();
            }

            foreach (var item in numbers)
            {
                total += item;
            }

            Console.WriteLine($"Sum: {total}");
        }
    }
}
