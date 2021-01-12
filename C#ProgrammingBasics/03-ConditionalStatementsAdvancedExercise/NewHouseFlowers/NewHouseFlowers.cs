using System;

namespace NewHouseFlowers
{
    class NewHouseFlowers
    {
        static void Main(string[] args)
        {
            string flowersType = Console.ReadLine();
            int countFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double singlePrice = 0;

            if (flowersType == "Roses")
            {
                singlePrice = 5;
                double price = singlePrice * countFlowers;

                if (countFlowers > 80)
                {
                    price *= 0.90;

                    if (budget >= price)
                    {
                        double more = budget - price;
                        Console.WriteLine($"Hey, you have a great garden with {countFlowers} {flowersType} and {more:f2} leva left.");
                    }
                    else
                    {
                        double more = price - budget;
                        Console.WriteLine($"Not enough money, you need {more:f2} leva more.");
                    }
                }
                else
                {
                    if (budget >= price)
                    {
                        double more = budget - price;
                        Console.WriteLine($"Hey, you have a great garden with {countFlowers} {flowersType} and {more:f2} leva left.");
                    }
                    else
                    {
                        double more = price - budget;
                        Console.WriteLine($"Not enough money, you need {more:f2} leva more.");
                    }
                }
            }

            


        }
    }
}
