using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<double>> shoppCard = new Dictionary<string, List<double>>();
            

            while (input != "buy")          
            {
                string[] items = input.Split();             // Beer 2.20 100
                string product = items[0];                  
                double price = double.Parse(items[1]);          // Beer 3.20 50
                double quantity = double.Parse(items[2]);

                if (!shoppCard.ContainsKey(product))
                {
                    shoppCard.Add(product, new List<double> { price, quantity});

                }

                else
                {
                    shoppCard[product][0] = price;
                    shoppCard[product][1] += quantity;
                }

                input = Console.ReadLine();
            }           

            foreach (var item in shoppCard)
            {
                double price = item.Value[0] * item.Value[1];
                
                Console.WriteLine($"{item.Key} -> {price:f2}");
            }
        }
    }
}
