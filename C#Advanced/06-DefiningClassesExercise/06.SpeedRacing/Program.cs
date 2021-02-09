using System;
using System.Collections.Generic;

namespace _06.SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carInput[0];
                double fuelAmount = double.Parse(carInput[1]);
                double fuelConsumptionPerKm = double.Parse(carInput[2]);

                Car currentCar = new Car(model, fuelAmount, fuelConsumptionPerKm, 0);
                cars.Add(currentCar);
            }

            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (commands[0] != "End")
            {
                string model = commands[1];
                double amountOfKm = double.Parse(commands[2]);

                foreach (var car in cars)
                {
                    if (model == car.Model)
                    {
                        car.CarMoving(car, amountOfKm);
                    }
                }

                commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
