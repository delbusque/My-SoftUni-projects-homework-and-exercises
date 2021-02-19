using System;

namespace TrainingHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenghtMeters = double.Parse(Console.ReadLine());
            double widthMeters = double.Parse(Console.ReadLine());

            double lenght = lenghtMeters * 100;
            double width = widthMeters * 100;
            double area = lenght * width;
            double coridor = lenght * 100;
            double workingPlace = 70 * 120;

            Console.WriteLine(Math.Round((area - coridor) / workingPlace) - 3);

        }
    }
}
