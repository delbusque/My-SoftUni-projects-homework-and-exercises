using System;

namespace TradeCommissions
{
    class TradeCommissions
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double profit = double.Parse(Console.ReadLine());

            if (town == "Sofia")
            {
                if (0 <= profit && profit <= 500)
                {
                    Console.WriteLine($"{profit * 0.05:f2}");
                }
                else if (500 < profit && profit <= 1000)
                {
                    Console.WriteLine($"{profit * 0.07:f2}");
                }
                else if (1000 < profit && profit <= 10000)
                {
                    Console.WriteLine($"{profit * 0.08:f2}");
                }
                else if (profit > 10000)
                {
                    Console.WriteLine($"{profit * 0.12:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

            else if (town == "Varna")

            {
                if (0 <= profit && profit <= 500)
                {
                    Console.WriteLine($"{profit * 0.045:f2}");
                }
                else if (500 < profit && profit <= 1000)
                {
                    Console.WriteLine($"{profit * 0.075:f2}");
                }
                else if (1000 < profit && profit <= 10000)
                {
                    Console.WriteLine($"{profit * 0.10:f2}");
                }
                else if (profit > 10000)
                {
                    Console.WriteLine($"{profit * 0.13:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

            else if (town == "Plovdiv")

            {
                if (0 <= profit && profit <= 500)
                {
                    Console.WriteLine($"{profit * 0.055:f2}");
                }
                else if (500 < profit && profit <= 1000)
                {
                    Console.WriteLine($"{profit * 0.08:f2}");
                }
                else if (1000 < profit && profit <= 10000)
                {
                    Console.WriteLine($"{profit * 0.12:f2}");
                }
                else if (profit > 10000)
                {
                    Console.WriteLine($"{profit * 0.145:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
