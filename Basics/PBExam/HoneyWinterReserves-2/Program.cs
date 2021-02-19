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

                for (int i = 1; i <= 6; i++)
                {
                    double monthHarvest = double.Parse(Console.ReadLine());

                    beeHarvest += monthHarvest;           
                }
                
                if (beeHarvest < 0)
                {
                    Console.WriteLine($"{beeName} was banished for gluttony");
                }
                
                totalHarvest += beeHarvest;

                if (totalHarvest >= honeyTarget)
                {
                    double more = totalHarvest - honeyTarget;
                    Console.WriteLine($"Well done! Honey surplus {more:f2}.");
                    Environment.Exit(0);
                }

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
