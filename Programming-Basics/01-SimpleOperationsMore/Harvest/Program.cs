using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int yards = int.Parse(Console.ReadLine());
            double vinegardKgPerYard = double.Parse(Console.ReadLine());
            int neededLiters = int.Parse(Console.ReadLine());
            
            int workers = int.Parse(Console.ReadLine());

            double vinegardKg = yards * vinegardKgPerYard * 0.40;
            double madeLiters = vinegardKg / 2.5;

            if (neededLiters > madeLiters)
            {
                double more = Math.Floor(neededLiters - madeLiters);
                Console.WriteLine($"It will be a tough winter! More {more} liters wine needed.");
            }
            else if (neededLiters <= madeLiters)
            {
                madeLiters = Math.Floor(madeLiters);
                double more = Math.Ceiling(madeLiters - neededLiters);
                double perPerson = more / workers;
                double Person = Math.Ceiling(perPerson);

                Console.WriteLine($"Good harvest this year! Total wine: {madeLiters} liters.");
                Console.WriteLine($"{more} liters left -> {Person} liters per person.");
            }

        }
    }
}
