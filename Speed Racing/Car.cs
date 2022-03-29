using System;

namespace Speed_Racing
{
    public class Car
    {
        private string Model;
        private double FuelAmount;
        private double FuelConsumptionPerKilometer;
        private double Travelleddistance;

        public Car(string model, double fuelamount, double fuelconsumptionfor1km)
        {
            this.Model = model;
            this.FuelAmount = fuelamount;
            this.FuelConsumptionPerKilometer = fuelconsumptionfor1km;
            this.Travelleddistance = 0;
        }

        public string model 
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public double fuelAmount
        {
            get { return this.fuelAmount; }
            set { this.fuelAmount = value; }
        }
        public double fuelConsumptionPerKilometer
        {
            get { return this.fuelConsumptionPerKilometer; }
            set { this.fuelConsumptionPerKilometer = value; }
        }

        public void Drive(string model,  double amountOfKm)
        {
            var fuelNeeded = amountOfKm * this.FuelConsumptionPerKilometer;
            if (this.fuelAmount >= fuelNeeded)
            {
                this.fuelAmount -= fuelNeeded;
                this.Travelleddistance += amountOfKm;
            }
            else
            {
                System.Console.WriteLine($"Insufficient fuel for the drive"); ;
            }
        }

        public string Details() 
        {
            return $"{this.model} {this.fuelAmount} {this.Travelleddistance}";
        }
    }
}
