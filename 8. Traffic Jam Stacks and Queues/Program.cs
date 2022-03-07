using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam_Stacks_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            var queue = new Queue<string>();
            int counter = 0;

            while (command != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (queue.Count == 0) break;
                       
                        string currentCar = queue.Dequeue();
                        Console.WriteLine($"{currentCar} passed!");
                        counter++;
                    }
                }
                else queue.Enqueue(command);

                command = Console.ReadLine();
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
