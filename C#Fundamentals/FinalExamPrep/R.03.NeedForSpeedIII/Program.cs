using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using System.Linq;

namespace R._03.NeedForSpeedIII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> cars = new Dictionary<string, List<int>>(); // millage, fuel

            for (int i = 0; i < n; i++)
            {
                string[] carCmdArgs = Console.ReadLine().Split("|");
                cars.Add(carCmdArgs[0], new List<int>());
                cars[carCmdArgs[0]].Add(int.Parse(carCmdArgs[1]));
                cars[carCmdArgs[0]].Add(int.Parse(carCmdArgs[2]));
            }

            string[] cmdArg = Console.ReadLine().Split(" : ");

            while (cmdArg[0] != "Stop")
            {
                string command = cmdArg[0];
                string car = cmdArg[1];

                if (command == "Drive")
                {
                    int distance = int.Parse(cmdArg[2]);
                    int fuel = int.Parse(cmdArg[3]);

                    if (cars.ContainsKey(car))
                    {
                        if (cars[car][1] < fuel)
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        else
                        {
                            cars[car][1] -= fuel;
                            cars[car][0] += distance;
                            Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                            if (cars[car][0] >= 100000)
                            {
                                Console.WriteLine($"Time to sell the {car}!"); 
                                cars.Remove(car);                               
                            }
                        }
                    }
                }

                else if (command == "Refuel")
                {
                    int fuel = int.Parse(cmdArg[2]);

                    if (cars[car][1] < 75)
                    {
                        int emptyTank = 75 - cars[car][1];

                        if (emptyTank >= fuel)
                        {
                            cars[car][1] += fuel;
                            Console.WriteLine($"{car} refueled with {fuel} liters");
                        }
                        else
                        {
                            int fill = fuel - ((cars[car][1] + fuel) - 75);
                            cars[car][1] += fill;
                            Console.WriteLine($"{car} refueled with {fill} liters");
                        }
                    }
                }

                else if (command == "Revert")
                {
                    int km = int.Parse(cmdArg[2]);

                    cars[car][0] -= km;

                    if (cars[car][0] < 10000)
                    {
                    cars[car][0] = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{car} mileage decreased by {km} kilometers");
                    }
                }

               cmdArg = Console.ReadLine().Split(" : ");

            }

            foreach (var item in cars.OrderByDescending(c=>c.Value[0]).ThenBy(k=>k.Key))
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value[0]} kms, Fuel in the tank: {item.Value[1]} lt.");
            }

        }
    }
}
