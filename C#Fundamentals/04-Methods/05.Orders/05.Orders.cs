using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Recipie(product, quantity);

        }

        static void Recipie(string product, int count)
        {
            double price = 0;

            if (product == "coffee")
            {
                price = 1.50 * count;
            }
            else if (product == "water")
            {
                price = 1.00 * count;
            }
            else if (product == "coke")
            {
                price = 1.40 * count;
            }
            else if (product == "snacks")
            {
                price = 2.00 * count;
            }

            Console.WriteLine($"{price:f2}");
        }

    }
}
