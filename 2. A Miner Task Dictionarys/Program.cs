using System;
using System.Collections.Generic;

namespace _2._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            var materials = new Dictionary<string, int>();

            while (command != "stop")
            {
                string mineral = command;
                int quantity = int.Parse(Console.ReadLine());
                if (!materials.ContainsKey(mineral))
                {
                    materials.Add(mineral, 0);
                }
                materials[mineral] += quantity;

                command = Console.ReadLine();
            }

            foreach (var item in materials)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
