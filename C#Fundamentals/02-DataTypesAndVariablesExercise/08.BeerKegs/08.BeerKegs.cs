using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double maxVolume = double.MinValue;
            string biggestModel = string.Empty;
            double maxRadius = 0;
            int maxHeight = 0;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    biggestModel = model;
                    maxRadius = radius;
                    maxHeight = height;
                }

            }

            Console.WriteLine(biggestModel);
        }
    }
}
