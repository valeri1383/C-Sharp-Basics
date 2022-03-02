using System;
using System.Collections.Generic;

namespace P_rates_Exam_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string token = Console.ReadLine();
            var citys = new Dictionary<string, List<int>>();

            while (token != "Sail")
            {
                string town = token.Split("||")[0];
                int population = int.Parse(token.Split("||")[1]);
                int gold = int.Parse(token.Split("||")[2]);
                if (!citys.ContainsKey(town))
                {
                    citys.Add(town, new List<int>());
                    citys[town].Add(population);
                    citys[town].Add(gold);
                }
                else
                {
                    citys[town][0] += population;
                    citys[town][1] += gold;
                }

                token = Console.ReadLine();
            }

            string events = Console.ReadLine();

            while (events != "End")
            {
                string action = events.Split("=>")[0];
                string town = events.Split("=>")[1];

                if (action == "Plunder")
                {
                    int people = int.Parse(events.Split("=>")[2]);
                    int gold = int.Parse(events.Split("=>")[3]);
                    citys[town][0] -= people;
                    citys[town][1] -= gold;
                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                    if (citys[town][0] <= 0 || citys[town][1] <= 0)
                    {
                        citys.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }
                else if (action == "Prosper")
                {
                    int gold = int.Parse(events.Split("=>")[2]);
                    if (double.IsNegative(gold))
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        citys[town][1] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {citys[town][1]} gold.");
                    }
                    
                }
                
                events = Console.ReadLine();
            }

            Console.WriteLine($"Ahoy, Captain! There are {citys.Count} wealthy settlements to go to:");
            foreach (var item in citys.Keys)
            {
                Console.WriteLine($"{item} -> Population: {citys[item][0]} citizens, Gold: {citys[item][1]} kg");
            }
        }
    }
}
