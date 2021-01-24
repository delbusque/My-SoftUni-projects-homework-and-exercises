using System;
using System.Collections.Generic;

namespace _04.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> atlas = new Dictionary<string, Dictionary<string, List<string>>>();
            string continent = string.Empty;
            string country = string.Empty;
            string city = string.Empty;


            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                continent = input[0];
                country = input[1];
                city = input[2];

                if (!atlas.ContainsKey(continent))
                {
                    atlas.Add(continent, new Dictionary<string, List<string>>());

                    if (!atlas[continent].ContainsKey(country))
                    {
                        atlas[continent].Add(country, new List<string>());
                        atlas[continent][country].Add(city);
                    }
                }
                else
                {
                    if (!atlas[continent].ContainsKey(country))
                    {
                        atlas[continent].Add(country, new List<string>());
                        atlas[continent][country].Add(city);
                    }
                    else
                    {
                        atlas[continent][country].Add(city);
                    }
                }

            }

            foreach (var cont in atlas)
            {
                Console.WriteLine($"{cont.Key}:");

                foreach (var countr in cont.Value)
                {
                    Console.WriteLine($"{countr.Key} -> {string.Join(", ", countr.Value)}");
                }
            }
        }
    }
}
