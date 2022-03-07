using System;
using System.Collections.Generic;

namespace _7._Hot_Potato_Stacks_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split();
            var queue = new Queue<string>(names);
            int n = int.Parse(Console.ReadLine());
            int counter = 1;

            while (queue.Count > 1)
            {
                string currentName = queue.Dequeue();

                if (counter == n)
                {
                    Console.WriteLine($"Removed {currentName}");
                    counter = 1;
                    continue;
                }

                else queue.Enqueue(currentName);
               
                counter++;
            }

            Console.WriteLine($"Last is {string.Join("", queue)}");
        }
    }
}
