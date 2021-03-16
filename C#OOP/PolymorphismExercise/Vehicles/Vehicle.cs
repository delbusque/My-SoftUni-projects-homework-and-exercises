using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;

        protected Vehicle(double fuelQuantity, double litersPerKm, double tankCapacity, double airConParam)
        {            
            LitersPerKm = litersPerKm;
            AirConParam = airConParam;
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
        }

        private double AirConParam { get; set; }
        public double FuelQuantity { get => fuelQuantity; private set
            {

                if (value > TankCapacity)
                {
                    value = 0;
                }
                else
                {
                    fuelQuantity = value;
                }
            }
                }
        public double LitersPerKm { get; private set; }

        public double TankCapacity { get; set; }

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

        public void DriveEmpty(double distance)
        {
            double usedFuel = distance * LitersPerKm;

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
                if (fuel > 0)
                {
                    if (GetType().Name == "Truck")
                    {
                        if (fuel > TankCapacity - FuelQuantity)
                        {
                            Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
                        }
                        else
                        {
                            FuelQuantity = FuelQuantity + (fuel * 0.95);
                        }
                    }
                    else
                    {
                        if (fuel > TankCapacity - FuelQuantity)
                        {
                            Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
                        }
                        else
                        {
                            FuelQuantity += fuel;
                        }
                    }
                }

            else
            {
                Console.WriteLine("Fuel must be a positive number");
            }           
        }
    }
}
