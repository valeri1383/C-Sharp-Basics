using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Average_Student_Grades_Nested_Dict
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, List<string>>();

            for (int i = 0; i < studentCount; i++)
            {
                var token = Console.ReadLine().Split();
                string name = token[0];
                double grade = double.Parse(token[1]);
                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new List<string>());
                }

                string newValue = grade.ToString("F2");
                dict[name].Add(newValue);
            }

            foreach (var item in dict.Keys)
            {
                double sum = 0;
                foreach (var el in dict[item])
                {
                    sum += double.Parse(el);
                }
                double total = sum / dict[item].Count;
                
                Console.WriteLine($"{item} -> {string.Join(" ", dict[item])} (avg: {total:F2})");
            }
        }
    }
}
