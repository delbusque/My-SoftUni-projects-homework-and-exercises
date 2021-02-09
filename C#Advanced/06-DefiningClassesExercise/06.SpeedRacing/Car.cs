using System;
using System.Collections.Generic;
using System.Text;

namespace _06.SpeedRacing
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public Car(string model, double fuelAmount, double fuelConsumption, double travelledDistance)
        : this(model, fuelAmount, fuelConsumption)
        {
            TravelledDistance = travelledDistance;
        }


        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKm { get; set; }

        public double TravelledDistance { get; set; }

        public void CarMoving(Car car, double amountOfKm)
        {
            if (car.FuelAmount >= car.FuelConsumptionPerKm * amountOfKm)
            {
                car.FuelAmount -= car.FuelConsumptionPerKm * amountOfKm ;
                car.TravelledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
