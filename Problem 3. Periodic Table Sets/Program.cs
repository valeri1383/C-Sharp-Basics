using System;
using System.Collections.Generic;

namespace Problem_3._Periodic_Table_Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var uniqueElements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                var elements = Console.ReadLine().Split();
                foreach (var item in elements)
                {
                    uniqueElements.Add(item);
                }

            }
            Console.WriteLine(string.Join(" ", uniqueElements));
        }
    }
}
