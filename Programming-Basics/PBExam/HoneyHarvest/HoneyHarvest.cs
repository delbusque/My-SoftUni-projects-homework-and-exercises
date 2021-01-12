using System;

namespace HoneyHarvest
{
    class HoneyHarvest
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowersNumber = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double totalHarvest = 0;

            if (season == "Spring")
            {
                switch (flowerType)
                {
                    case "Sunflower":
                        totalHarvest += flowersNumber * 10;
                        break;

                    case "Daisy":
                        totalHarvest += flowersNumber * 12 * 1.10;
                        break;

                    case "Lavender":
                        totalHarvest += flowersNumber * 12;
                        break;

                    case "Mint":
                        totalHarvest += flowersNumber * 10 * 1.10;
                        break;
                }
            }

            if (season == "Summer")
            {
                switch (flowerType)
                {
                    case "Sunflower":
                        totalHarvest += flowersNumber * 8 * 1.10;
                        break;

                    case "Daisy":
                        totalHarvest += flowersNumber * 8 * 1.10;
                        break;

                    case "Lavender":
                        totalHarvest += flowersNumber * 8 * 1.10;
                        break;

                    case "Mint":
                        totalHarvest += flowersNumber * 12 * 1.10;
                        break;
                }
            }

            if (season == "Autumn")
            {
                switch (flowerType)
                {
                    case "Sunflower":
                        totalHarvest += flowersNumber * 12 * 0.95;
                        break;

                    case "Daisy":
                        totalHarvest += flowersNumber * 6 * 0.95;
                        break;

                    case "Lavender":
                        totalHarvest += flowersNumber * 6 * 0.95;
                        break;

                    case "Mint":
                        totalHarvest += flowersNumber * 6 * 0.95;
                        break;
                }
            }

            Console.WriteLine($"Total honey harvested: {totalHarvest:f2}");
        }
    }
}
