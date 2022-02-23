using System;
using System.Collections.Generic;


namespace Plant_Discovery_Exam_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            var plants = new Dictionary<string,  List<int>>();

            for (int i = 0; i < n; i++)
            {
                string[] token = Console.ReadLine().Split("<->");
                string plant = token[0];
                int rarity = int.Parse(token[1]);

                if (!plants.ContainsKey(plant))
                {
                    plants[plant] = new List<int>();
                }
            
                plants[plant].Add(rarity);
            }

            string command = Console.ReadLine();
            

            while (command != "Exhibition")
            {
                
                string action = command.Split(": ")[0];
                string token = command.Split(": ")[1];
                string plant = token.Split(" - ")[0];

                if (action == "Rate")
                {
                    
                    int rating = int.Parse(token.Split(" - ")[1]);
                    plants[plant].Add(0);
                    plants[plant].Add(0);
                    plants[plant][2]++;
                    plants[plant][1] += rating;
                    
                }
                else if (action == "Update")
                {
                    int newRarity = int.Parse(token.Split(" - ")[1]);
                    plants[plant][0] = newRarity;
                }
                else if (action == "Reset")
                {
                    plants[plant][1] = 0;
                }
                else
                {
                    Console.WriteLine("error");
                }


                command = Console.ReadLine();
            }

            
            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in plants.Keys)
            {
                double result = (double)plants[item][1] / plants[item][2];
                Console.WriteLine($"- {item}; Rarity: {plants[item][0]}; Rating: {result:F2}");
            }

        }
    }
}
