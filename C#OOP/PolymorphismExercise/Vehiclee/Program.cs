using System;

namespace Vehicles
{
    public  class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInput = Console.ReadLine().Split();
            string[] truckInput = Console.ReadLine().Split();

            double carFuelQuantity = double.Parse(carInput[1]);
            double carPerKm = double.Parse(carInput[2]);

            double truckFuelQuantity = double.Parse(truckInput[1]);
            double truckPerKm = double.Parse(truckInput[2]);

            int n = int.Parse(Console.ReadLine());
            Car car = new Car(carFuelQuantity, carPerKm, 0.9);
            Truck truck = new Truck(truckFuelQuantity, truckPerKm, 1.6);

            for (int i = 0; i < n; i++)
            {
                string[] vehicleCommand = Console.ReadLine().Split();

                string command = vehicleCommand[0];
                string vehicleType = vehicleCommand[1];
                double commandParam = double.Parse(vehicleCommand[2]);

                switch (command)
                {
                    case "Drive":
                        if (vehicleType == "Car")
                        {
                            car.Drive(commandParam);
                        }
                        else if (vehicleType == "Truck")
                        {
                            truck.Drive(commandParam);
                        }
                        break;

                    case "Refuel":
                        if (vehicleType == "Car")
                        {
                            car.Refuel(commandParam);
                        }
                        else if (vehicleType == "Truck")
                        {
                            truck.Refuel(commandParam);
                        }
                        break;
                }

            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");

        }
    }
}
