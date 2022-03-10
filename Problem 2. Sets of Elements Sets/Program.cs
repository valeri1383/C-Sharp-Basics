using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Sets_of_Elements_Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split();
            int n = int.Parse(numbers[0]);
            int m = int.Parse(numbers[1]);
            var set1 = new HashSet<int>();
            var set2 = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                set1.Add(num);
            }

            for (int i = 0; i < m; i++)
            {
                int num = int.Parse(Console.ReadLine());
                set2.Add(num);
            }

            var result = set1.Intersect(set2);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
