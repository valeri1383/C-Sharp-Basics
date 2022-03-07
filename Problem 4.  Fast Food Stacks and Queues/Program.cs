using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4.__Fast_Food_Stacks_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQantity = int.Parse(Console.ReadLine());
            var queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int biggestOrder = int.MinValue;
            bool completeOrders = true;

            while (queue.Any())
            {
                int order = queue.Peek();
                if (order > biggestOrder) biggestOrder = order;

                if (foodQantity >= order)
                {
                    foodQantity -= order;
                    queue.Dequeue();
                }
                else
                {
                    completeOrders = false;
                    break;
                }
            }

            Console.WriteLine(biggestOrder);
            if (completeOrders) Console.WriteLine("Orders complete");
           
            else Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
        }
    }
}
