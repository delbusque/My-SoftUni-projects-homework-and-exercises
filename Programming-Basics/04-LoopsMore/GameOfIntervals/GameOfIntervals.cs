using System;

namespace GameOfIntervals
{
    class GameOfIntervals
    {
        static void Main(string[] args)
        {
            int rounds = int.Parse(Console.ReadLine());

            double points = 0;

            int groupTo10 = 0;
            int groupTo20 = 0;
            int groupTo30 = 0;
            int groupTo40 = 0;
            int groupTo50 = 0;
            int groupInvalid = 0;


            for (int i = 1; i <= rounds; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum >= 0 && currentNum < 10)
                {
                    points += currentNum * 0.20;
                    groupTo10++;
                }

                else if (currentNum >= 10 && currentNum < 20)
                {
                    points += currentNum * 0.30;
                    groupTo20++;
                }

                else if (currentNum >= 20 && currentNum < 30)
                {
                    points += currentNum * 0.40;
                    groupTo30++;
                }

                else if (currentNum >= 30 && currentNum < 40)
                {
                    points += 50;
                    groupTo40++;
                }

                else if (currentNum >= 40 && currentNum <= 50)
                {
                    points += 100;
                    groupTo50++;
                }

                else
                {
                    points /= 2;
                    groupInvalid++;
                }

            }

            double groupTo10Percentage = 100.00 * groupTo10 / rounds;
            double groupTo20Percentage = 100.00 * groupTo20 / rounds;
            double groupTo30Percentage = 100.00 * groupTo30 / rounds;
            double groupTo40Percentage = 100.00 * groupTo40 / rounds;
            double groupTo50Percentage = 100.00 * groupTo50 / rounds;
            double groupInvalidPercentage = 100.00 * groupInvalid / rounds;

            Console.WriteLine($"{points:f2}");
            Console.WriteLine($"From 0 to 9: {groupTo10Percentage:f2}%");
            Console.WriteLine($"From 10 to 19: {groupTo20Percentage:f2}%");
            Console.WriteLine($"From 20 to 29: {groupTo30Percentage:f2}%");
            Console.WriteLine($"From 30 to 39: {groupTo40Percentage:f2}%");
            Console.WriteLine($"From 40 to 50: {groupTo50Percentage:f2}%");
            Console.WriteLine($"Invalid numbers: {groupInvalidPercentage:f2}%");


        }
    }
}
