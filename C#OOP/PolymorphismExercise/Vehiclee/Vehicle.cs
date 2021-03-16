using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        protected Vehicle(double fuelQuantity, double litersPerKm, double airConParam)
        {
            FuelQuantity = fuelQuantity;
            LitersPerKm = litersPerKm;
            AirConParam = airConParam;
        }

        private double AirConParam { get; set; }
        public double FuelQuantity { get; private set; }
        public double LitersPerKm { get; private set; }

        public virtual void Drive(double distance)
        {
            double usedFuel = distance * LitersPerKm + distance * AirConParam;

            if (FuelQuantity >= usedFuel)
            {
                FuelQuantity -= usedFuel;
                Console.WriteLine($"{GetType().Name} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
            }
        }

        public void Refuel(double fuel)
        {
            if (GetType().Name == "Truck")
            {
                FuelQuantity = FuelQuantity + (fuel * 0.95);

            }
            else
            {
                FuelQuantity += fuel;
            }
        }
    }
}
