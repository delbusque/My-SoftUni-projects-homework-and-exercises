using System;

namespace Aquarium
{
    class Aquarium
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double reservedSpaceInPercentage = double.Parse(Console.ReadLine());

            double wholeArea = lenght * width * height * 0.001;
            double reservedSpace = wholeArea * reservedSpaceInPercentage * 0.01;
            double waterArea = wholeArea - reservedSpace;

            Console.WriteLine($"{waterArea.ToString("F3")}");

        }
    }
}
