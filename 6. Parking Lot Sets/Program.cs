using System;
using System.Collections.Generic;

namespace _6._Parking_Lot_Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var parkingLot = new HashSet<string>();

            while (input != "END")
            {
                var token = input.Split(", ");
                string direction = token[0];
                string reg = token[1];
                if (direction == "IN")
                {
                    parkingLot.Add(reg);
                }
                else if (direction == "OUT")
                {
                    parkingLot.Remove(reg);
                }

                input = Console.ReadLine();
            }

            if (parkingLot.Count > 0) Console.WriteLine(string.Join("\n", parkingLot));

            else Console.WriteLine("Parking Lot is Empty");
            
        }
    }
}
