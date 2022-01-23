using System;
using System.Collections.Generic;
using System.Linq;


namespace _3._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> newList = new List<int>();
            bool list1isSmallest = false;

            int biggestList = 0;
            if (list1.Count >= list2.Count)
            {
                biggestList = list1.Count;
            }
            else
            {
                biggestList = list2.Count;
            }


            for (int i = 0; i < biggestList; i++)
            {
                if (list1.Count > i)
                {
                    newList.Add(list1[i]);
                }
                if (list2.Count > i)
                {
                    newList.Add(list2[i]);
                }

            }
            
            Console.WriteLine(string.Join(" ", newList));
        }

        
    }
}
