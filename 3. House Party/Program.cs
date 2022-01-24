using System;
using System.Collections.Generic;

namespace _3._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> peopleList = new List<string>();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string command = Console.ReadLine();
                bool isGoing = true;
                if (command.Contains("not")) isGoing = false;
                                                                
                string name = command.Split()[0];
                
                if (isGoing == true)
                {
                    if (peopleList.Contains(name)) Console.WriteLine($"{name} is already in the list!");

                    else peopleList.Add(name);
                    
                }
                else if (isGoing == false)
                {
                    if (peopleList.Contains(name)) peopleList.Remove(name);
                    else Console.WriteLine($"{name} is not in the list!");
                }
            }

            foreach (var item in peopleList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
