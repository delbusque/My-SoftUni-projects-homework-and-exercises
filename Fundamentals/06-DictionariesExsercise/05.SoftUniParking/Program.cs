using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int logs = int.Parse(Console.ReadLine());

            Dictionary<string, string> parkingData = new Dictionary<string, string>();

            for (int i = 0; i < logs; i++)
            {
                string[] inputCommand = Console.ReadLine().Split();

                string status = inputCommand[0];

                if (status == "register")
                {                   
                    string name = inputCommand[1];
                    string plateNumber = inputCommand[2];

                    if (!parkingData.ContainsKey(name))
                    {
                        parkingData.Add(name, plateNumber);

                        Console.WriteLine($"{name} registered {plateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                    }
                }

                else if (status == "unregister")
                {
                    string name = inputCommand[1];

                    if (!parkingData.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{name} unregistered successfully");
                        parkingData.Remove(name);
                    }
                }
           
            }

            foreach (var item in parkingData)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
