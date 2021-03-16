using System;

namespace Vehicles
{
    public  class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInput = Console.ReadLine().Split();
            string[] truckInput = Console.ReadLine().Split();
            string[] busInput = Console.ReadLine().Split();

            double carFuelQuantity = double.Parse(carInput[1]);
            double carPerKm = double.Parse(carInput[2]);
            double carTank = double.Parse(carInput[3]);

            double truckFuelQuantity = double.Parse(truckInput[1]);
            double truckPerKm = double.Parse(truckInput[2]);
            double truckTank = double.Parse(truckInput[3]);

            double busFuelQuantity = double.Parse(busInput[1]);
            double busPerKm = double.Parse(busInput[2]);
            double busTank = double.Parse(busInput[3]);


            int n = int.Parse(Console.ReadLine());
            Vehicle car = new Car(carFuelQuantity, carPerKm, carTank, 0.9);
            Vehicle truck = new Truck(truckFuelQuantity, truckPerKm, truckTank, 1.6);
            Vehicle bus = new Bus(busFuelQuantity, busPerKm, busTank, 1.4);


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
                        else if (vehicleType == "Bus")
                        {
                            bus.Drive(commandParam);
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
                        else if (vehicleType == "Bus")
                        {
                            bus.Refuel(commandParam);
                        }
                        break;

                    case "DriveEmpty":
                        bus.Drive(commandParam);
                        break;
                }

            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");

        }
    }
}
