using System;
using System.Collections.Generic;
using System.Linq;

namespace Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var carList = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var token = Console.ReadLine().Split();
                var model = token[0];
                var fuelAmount = double.Parse(token[1]);
                var fuelConsumptionFor1km = double.Parse(token[1]);

                Car car = new Car(model, fuelAmount, fuelConsumptionFor1km);
                carList.Add(car);
            }

            var command = Console.ReadLine();

            while (command != "End")
            {              
                var carModel = command.Split()[1];
                var amountOfKm = double.Parse(command.Split()[2]);
                Car currentModel = carList.Find(x => x.model == carModel);
                
                currentModel.Drive(carModel, amountOfKm);

                command = Console.ReadLine();
            }

            foreach (var item in carList)
            {
                Console.WriteLine(item.Details());
            }

        }
    }
}
