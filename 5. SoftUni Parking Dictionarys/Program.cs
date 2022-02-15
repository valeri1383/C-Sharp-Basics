using System;
using System.Collections.Generic;

namespace _5._SoftUni_Parking_Dictionarys
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var parkingLot = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string token = Console.ReadLine();
                string action = token.Split()[0];
                string name = token.Split()[1];
                

                if (action == "register")
                {
                    string reg = token.Split()[2];
                    if (parkingLot.ContainsKey(name))
                    {
                        Console.WriteLine("ERROR: already registered with plate number {licensePlateNumber}");
                    }
                    else
                    {
                        parkingLot.Add(name, reg);
                        Console.WriteLine($"{name} registered {reg} successfully");
                    }
                    
                }
                else if (action == "unregister")
                {
                    if (!parkingLot.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        parkingLot.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                }
            }

            foreach (var item in parkingLot.Keys)
            {
                Console.WriteLine($"{item} => {parkingLot[item]}");
            }
        }
    }
}
