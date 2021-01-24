using System;
using System.Collections.Generic;

namespace _03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

            string[] cmdArgs = Console.ReadLine().Split(", ");
            
            while (cmdArgs[0] != "Revision")
            {
                string shop = cmdArgs[0];
                string product = cmdArgs[1];
                double price = double.Parse(cmdArgs[2]);
                
                // decimal price = Math.Round(decimal.Parse(cmdArgs[2]), 2, MidpointRounding.AwayFromZero);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                    shops[shop].Add(product, price);
                }
                else
                {
                    shops[shop].Add(product, price);
                }

                cmdArgs = Console.ReadLine().Split(", ");
            }

            foreach (var item in shops)
            {
                Console.WriteLine($"{item.Key}->");            

                foreach (var prod in item.Value)
                {
                    Console.WriteLine($"Product: {prod.Key}, Price: {prod.Value}");
                }              
            }
        }
    }
}
