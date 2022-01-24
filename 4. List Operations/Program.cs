using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string action = command.Split()[0];

                if (action == "Add")
                {
                    int num = int.Parse(command.Split()[1]);
                    numbers.Add(num);
                }

                else if (action == "Insert")
                {
                    int num = int.Parse(command.Split()[1]);
                    int index = int.Parse(command.Split()[2]);
                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers.Insert(index, num);
                    }
                    else Console.WriteLine("Invalid index");
                    
                }
                else if (action == "Remove")
                {
                    int index = int.Parse(command.Split()[1]);
                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers.RemoveAt(index);
                    }
                    else Console.WriteLine("Invalid index");
                    
                }
                else if (action == "Shift")
                {
                    int count = int.Parse(command.Split()[2]);
                    if (command.Split()[1] == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int temp = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(temp);
                        }
                    }
                    else if (command.Split()[1] == "right")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int temp = numbers[numbers.Count - 1];
                            numbers.Remove(temp);
                            numbers.Insert(i, temp);
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
