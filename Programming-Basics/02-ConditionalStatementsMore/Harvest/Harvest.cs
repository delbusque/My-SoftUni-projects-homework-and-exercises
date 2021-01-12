using System;

namespace Harvest
{
    class Harvest
    {
        static void Main()
        {
            int yards = int.Parse(Console.ReadLine());
            double vinegardKgPerYard = double.Parse(Console.ReadLine());
            int neededLiters = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double vinegardKg = yards * vinegardKgPerYard * 0.40;
            double madeLiters = vinegardKg / 2.50;

            if (neededLiters >= madeLiters)
            {
                double more = Math.Floor(neededLiters - madeLiters);
                Console.WriteLine($"It will be a tough winter! More {more} liters wine needed.");
            }
            else if (neededLiters < madeLiters)
            {

                double more = Math.Ceiling(madeLiters - neededLiters);
                double perPerson = more / workers;
                double person = Math.Ceiling(perPerson);
                madeLiters = Math.Floor(madeLiters);

                Console.WriteLine($"Good harvest this year! Total wine: {madeLiters} liters.");
                Console.WriteLine($"{more} liters left -> {person} liters per person.");
            }

            



        }
    }
}