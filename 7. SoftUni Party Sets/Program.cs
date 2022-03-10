using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._SoftUni_Party_Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            string reservation = Console.ReadLine();
            var VIP = new HashSet<string>();
            var regular = new HashSet<string>();

            while (reservation != "PARTY")
            {
                if (reservation.Length != 8)
                {
                    continue;
                }
                char firstLetter = reservation.ToCharArray().ElementAt(0);
                if (char.IsNumber(firstLetter))
                {
                    VIP.Add(reservation);
                }
                else if (!char.IsNumber(firstLetter))
                {
                    regular.Add(reservation);
                }

                reservation = Console.ReadLine();
            }

            string checkInn = Console.ReadLine();
            while (checkInn != "END")
            {
                if (VIP.Contains(checkInn))
                {
                    VIP.Remove(checkInn);
                }
                else if (regular.Contains(checkInn))
                {
                    regular.Remove(checkInn);
                }

                checkInn = Console.ReadLine();
            }

            var result = VIP.Union(regular);
            Console.WriteLine(result.Count());
            Console.WriteLine(string.Join("\n", result));
        }
    }
}
