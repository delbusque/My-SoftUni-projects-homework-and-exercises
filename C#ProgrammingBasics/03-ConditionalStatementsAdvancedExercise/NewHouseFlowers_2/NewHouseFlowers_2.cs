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

            switch (flowersType)
            {
                case "Roses":
                    singlePrice = 5; break;

                case "Dahlias":
                    singlePrice = 3.80; break;

                case "Tulips":
                    singlePrice = 2.80; break;

                case "Narcissus":
                    singlePrice = 3.00; break;

                case "Gladiolus":
                    singlePrice = 2.50; break;
            }

            double price = singlePrice * countFlowers;

            if (flowersType == "Roses" && countFlowers > 80)
            {
                    price *= 0.90;
            }

            else if (flowersType == "Dahlias" && countFlowers > 90)
            {
                    price *= 0.85;
            }
            else if (flowersType == "Tulips" && countFlowers > 80)
            {
                    price *= 0.85;
            }

            else if (flowersType == "Narcissus" && countFlowers < 120)
            {
                    price *= 1.15;
            }

            else if (flowersType == "Gladiolus" && countFlowers < 80)
            {
                    price *= 1.20;
            }

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


