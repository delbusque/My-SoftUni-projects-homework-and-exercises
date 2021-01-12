using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace F._03.PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> plants = new Dictionary<string, List<int>>();

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split("<->");

                if (!plants.ContainsKey(cmdArgs[0]))
                {
                    plants.Add(cmdArgs[0], new List<int>());
                    plants[cmdArgs[0]].Add(int.Parse(cmdArgs[1]));
                }
                else
                {
                    plants[cmdArgs[0]].Clear();
                    plants[cmdArgs[0]].Add(int.Parse(cmdArgs[1]));

                }

            }

            string[] cmdCommands = Console.ReadLine().Split(": ");
            string command = cmdCommands[0];
            int count = 0;

            while (command != "Exhibition")
            {
                string tempCommandArgs = cmdCommands[1];
                string[] commandArgs = tempCommandArgs.Split(" - ");

                string plant = commandArgs[0];

                if (command == "Rate")
                {
                    int rating = int.Parse(commandArgs[1]);
                    if (plants[plant].Count == 1)
                    {
                        plants[plant].Add(rating);
                        count++;
                    }
                    else
                    {
                        plants[plant][1] += rating;
                        count++;
                    }

                }

                else if (command == "Update")
                {
                    int newRarity = int.Parse(commandArgs[1]);
                    plants[plant][0] = newRarity;
                }

                else if (command == "Reset")
                {
                    plants[plant][1] = 0;
                }

                else
                {
                    Console.WriteLine("error");
                }

                cmdCommands = Console.ReadLine().Split(": ");
            }

            Console.WriteLine("Plants for the exhibition:");
            Console.WriteLine();

            foreach (var item in plants)
            {
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value[0]}; Rating: {(item.Value[1] / count):f2}");
                Console.WriteLine();
            }
        }
    }
}
