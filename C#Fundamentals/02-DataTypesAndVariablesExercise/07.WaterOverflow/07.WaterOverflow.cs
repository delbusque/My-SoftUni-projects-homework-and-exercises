using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            short litersCount = 0;

            for (int i = 0; i < n; i++)
            {
                
                short liters = short.Parse(Console.ReadLine());
                litersCount += liters;

                if (litersCount > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    litersCount -= liters;
                }
            }

            Console.WriteLine(litersCount);
        }
    }
}
