﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._task
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            int lenth = numbers.Count - 1;

            for (int i = 0; i < lenth; i++)
            {
                if (i + 1 >= numbers.Count)
                {
                    break;
                }

                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] += numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    i = -1;
                }
                                
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
