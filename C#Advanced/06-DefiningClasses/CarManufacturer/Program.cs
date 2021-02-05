using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] tiresInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            List<Tire[]> tiresList = new List<Tire[]>();
            while (tiresInput[0] != "No")
            {
                Tire[] currTires = new Tire[4]
                {
                    new Tire(int.Parse(tiresInput[0]), double.Parse(tiresInput[1])),
                    new Tire(int.Parse(tiresInput[2]), double.Parse(tiresInput[3])),
                    new Tire(int.Parse(tiresInput[4]), double.Parse(tiresInput[5])),
                    new Tire(int.Parse(tiresInput[6]), double.Parse(tiresInput[7])),
                };

                tiresList.Add(currTires);

                tiresInput = Console.ReadLine().Split();
            }

            string[] enginesInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            List<Engine> enginesList = new List<Engine>();
            while (enginesInput[0] != "Engines")
            {
                Engine currEngine = new Engine(int.Parse(enginesInput[0]), double.Parse(enginesInput[1]));

                enginesList.Add(currEngine);

                enginesInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            string[] carsData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            List<Car> carsList = new List<Car>();
            while (carsData[0] != "Show")
            {
                int engineIndex = int.Parse(carsData[5]);
                int tiresIndex = int.Parse(carsData[6]);

                string make = carsData[0];
                string model = carsData[1];
                int year = int.Parse(carsData[2]);
                double fuelQuantity = double.Parse(carsData[3]);
                double fuelConsumption = double.Parse(carsData[4]);               
                Engine engine = enginesList[engineIndex];
                Tire[] tires = tiresList[tiresIndex];

                Car currCar = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tires);
                carsList.Add(currCar);

                carsData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            
            foreach (var car in carsList)
            {
                double tiresPressure = car.TirePressureSum(car.Tires);
                bool allowedTiresPressure = tiresPressure >= 9 && tiresPressure <= 10;
                
                
                if (car.Year >= 2017 && car.Engine.HorsePower >= 330 && allowedTiresPressure)
                {
                    car.Drive(20);
                    Console.WriteLine(car.WhoIAM());
                }
            }
        }
    }
}
