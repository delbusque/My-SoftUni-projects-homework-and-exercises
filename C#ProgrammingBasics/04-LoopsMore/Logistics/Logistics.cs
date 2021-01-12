using System;

namespace Logistics
{
    class Logistics
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int weight = 0;
            int weightBus = 0;
            int weightTruck = 0;
            int weightTrain = 0;

            for (int i = 1; i <= count; i++)
            {
                int current = int.Parse(Console.ReadLine());

                weight += current;

                if (current <= 3)
                {
                    weightBus += current;
                }

                else if (4 <= current && current <= 11)
                {
                    weightTruck += current;
                }

                else if (current >= 12)
                {
                    weightTrain += current;
                }
            }

            Console.WriteLine($"{((weightBus * 200) + (weightTruck * 175) + (weightTrain * 120)) * 1.00 / weight:f2}");
            Console.WriteLine($"{100.00 * weightBus / weight:f2}%");
            Console.WriteLine($"{100.00 * weightTruck / weight:f2}%");
            Console.WriteLine($"{100.00 * weightTrain / weight:f2}%");

        }
    }
}
