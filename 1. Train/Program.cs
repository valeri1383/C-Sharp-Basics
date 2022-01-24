using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string token = Console.ReadLine();

            while (token != "end")
            {
                string action = token.Split()[0];
                if (action == "Add")
                {
                    int people = int.Parse(token.Split()[1]);
                    train.Add(people);
                }
                else
                {
                    int extraPeople = int.Parse(token.Split()[0]);
                    for (int i = 0; i < train.Count; i++)
                    {
                        if (train[i] + extraPeople <= maxCapacity)
                        {
                            train[i] += extraPeople;
                            break;
                        }
                    }
                }
                
                token = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ",train));
        }
    }
}
