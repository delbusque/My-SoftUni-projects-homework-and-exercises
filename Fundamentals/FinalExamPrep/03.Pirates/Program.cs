using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace _03.Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> targetCities = new Dictionary<string, List<int>>();          

            string[] inputTargets = Console.ReadLine().Split("||");

            while (inputTargets[0] != "Sail")
            {
                string city = inputTargets[0];
                int population = int.Parse(inputTargets[1]);
                int gold = int.Parse(inputTargets[2]);

                if (!targetCities.ContainsKey(city))
                {
                    targetCities.Add(city, new List<int>());
                    targetCities[city].Add(population);
                    targetCities[city].Add(gold);
                }
                else
                {
                    targetCities[city][0] += population;
                    targetCities[city][1] += gold;
                }

                inputTargets = Console.ReadLine().Split("||");
            }

            string[] commands = Console.ReadLine().Split("=>");

            while (commands[0] != "End")
            {

                string pirateEvent = commands[0];
                string city = commands[1];

                if (pirateEvent == "Plunder")
                {
                    int people = int.Parse(commands[2]);
                    int gold = int.Parse(commands[3]);

                    targetCities[city][0] -= people;
                    targetCities[city][1] -= gold;

                    Console.WriteLine($"{city} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (targetCities[city][0] <= 0 || targetCities[city][1] <= 0)
                    {
                        targetCities.Remove(city);
                        Console.WriteLine($"{city} has been wiped off the map!");
                    }
                }

                else if (pirateEvent == "Prosper")
                {
                    int gold = int.Parse(commands[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                    }
                    else
                    {
                        targetCities[city][1] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {city} now has {targetCities[city][1]} gold.");
                    }                   
                }

                commands = Console.ReadLine().Split("=>");
            }

            if (targetCities.Count <= 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {targetCities.Count} wealthy settlements to go to:");

                foreach (var item in targetCities.OrderByDescending(x => x.Value[0]).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value[0]} citizens, Gold: {item.Value[1]} kg");
                }
            }
        }
    }
}
