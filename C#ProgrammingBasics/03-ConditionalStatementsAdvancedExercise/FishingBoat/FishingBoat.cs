using System;

namespace FishingBoat
{
    class FishingBoat
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double rent = 0;

            if (fishermen <= 6)
            {
                switch (season)
                {
                    case "Spring":
                        rent = 3000 * 0.90;
                        break;

                    case "Summer":
                    case "Autumn":
                        rent = 4200 * 0.90;
                        break;

                    case "Winter":
                        rent = 2600 * 0.90;
                        break;
                }
            }

            else if (6 < fishermen && fishermen <= 11)
            {
                switch (season)
                {
                    case "Spring":
                        rent = 3000 * 0.85;
                        break;

                    case "Summer":
                    case "Autumn":
                        rent = 4200 * 0.85;
                        break;

                    case "Winter":
                        rent = 2600 * 0.85;
                        break;
                }
            }

            else if (fishermen > 11)
            {
                switch (season)
                {
                    case "Spring":
                        rent = 3000 * 0.75;
                        break;

                    case "Summer":
                    case "Autumn":
                        rent = 4200 * 0.75;
                        break;

                    case "Winter":
                        rent = 2600 * 0.75;
                        break;
                }
            }

            if (fishermen % 2 == 0 && season != "Autumn")
            {
                rent *= 0.95;
            }

            if (budget >= rent)
            {
                double more = budget - rent;
                Console.WriteLine($"Yes! You have {more:f2} leva left.");
            }
            else
            {
                double more = rent - budget;
                Console.WriteLine($"Not enough money! You need {more:f2} leva.");
            }
            
            
        }
    }
}
