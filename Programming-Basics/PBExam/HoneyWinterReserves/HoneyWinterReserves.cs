using System;

namespace HoneyWinterReserves
{
    class HoneyWinterReserves
    {
        static void Main(string[] args)
        {
            double honeyTarget = double.Parse(Console.ReadLine());

            string beeName = Console.ReadLine();

            double totalHarvest = 0;

            while (beeName != "Winter has come")
            {
                double beeHarvest = 0;

                double firstMonth = double.Parse(Console.ReadLine());
                double secondMonth = double.Parse(Console.ReadLine());
                double thirdMonth = double.Parse(Console.ReadLine());
                double fourthMonth = double.Parse(Console.ReadLine());
                double fifthMonth = double.Parse(Console.ReadLine());
                double sixthMonth = double.Parse(Console.ReadLine());

                beeHarvest = (firstMonth) + (secondMonth) + (thirdMonth) + (fourthMonth) + (fifthMonth) + (sixthMonth);

                if (beeHarvest < 0)
                {
                    Console.WriteLine($"{beeName} was banished for gluttony");
                }

                totalHarvest += beeHarvest;

                beeName = Console.ReadLine();

            }

            if (totalHarvest >= honeyTarget)
            {
                double more = totalHarvest - honeyTarget;
                Console.WriteLine($"Well done! Honey surplus {more:f2}.");
            }

            else
            {
                double more = honeyTarget - totalHarvest;
                Console.WriteLine($"Hard Winter! Honey needed {more:f2}.");
            }
        }
    }
}
