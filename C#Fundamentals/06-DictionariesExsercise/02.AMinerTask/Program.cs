using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Dictionary<string, int> mining = new Dictionary<string, int>();

            while (resource != "stop")
            {
                if (!mining.ContainsKey(resource))
                {
                    mining.Add(resource, quantity);
                }
                else
                {
                    mining[resource] += quantity;
                }

                resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }
                quantity = int.Parse(Console.ReadLine());
            }

            foreach (var item in mining)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
