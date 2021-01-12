using System;

namespace Moving
{
    class Moving
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            int capacity = x * y * z;
            int packageSize = 1 * 1 * 1;

            int capacityCount = 0;

            string count = Console.ReadLine();
            
            while (count != "Done")

            {
                int packageCount = int.Parse(count);
                capacityCount += packageCount * packageSize;

                if (capacityCount < capacity)
                {
                    count = Console.ReadLine();
                }
                else
                {
                    int more = capacityCount - capacity;
                    Console.WriteLine($"No more free space! You need {more} Cubic meters more.");
                    Environment.Exit(0);
                }

            }

            Console.WriteLine($"{capacity - capacityCount} Cubic meters left.");
        }
    }
}
