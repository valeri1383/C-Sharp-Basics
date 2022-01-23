using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string token = Console.ReadLine();

            while (token != "end")
            {
                string command = token.Split()[0];


                if (command == "Contains")
                {
                    int num = int.Parse(token.Split()[1]);
                    if (numbers.Contains(num))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }

                else if (command == "PrintOdd")
                {
                    string result = "";
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 1)
                        {
                            result += ($"{numbers[i].ToString()} ");
                        }
                    }
                    Console.Write(result.TrimEnd());
                    Console.WriteLine();
                }

                else if (command == "PrintEven")
                {
                    string result = "";
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            result += ($"{numbers[i].ToString()} ");
                        }
                    }
                    Console.Write(result.TrimEnd());
                    Console.WriteLine();
                }

                else if (command == "GetSum")
                {
                    Console.WriteLine(numbers.Sum()); 
                }

                else if (command == "Filter")
                {
                    string sign = token.Split()[1];
                    int num = int.Parse(token.Split()[2]);

                    if (sign == ">")
                    {
                        List<int> filtered = new List<int>(numbers.FindAll(x => x > num));
                        Console.WriteLine(string.Join(" ", filtered));
                    }
                    else if (sign == "<")
                    {
                        List<int> filtered = new List<int>(numbers.FindAll(x => x < num));
                        Console.WriteLine(string.Join(" ", filtered));
                    }
                    else if (sign == "<=")
                    {
                        List<int> filtered = new List<int>(numbers.FindAll(x => x <= num));
                        Console.WriteLine(string.Join(" ", filtered));
                    }
                    else if (sign == ">=")
                    {
                        List<int> filtered = new List<int>(numbers.FindAll(x => x >= num));
                        Console.WriteLine(string.Join(" ", filtered));
                    }
                    
                }

                token = Console.ReadLine();
            }

            
        }
    }
}
