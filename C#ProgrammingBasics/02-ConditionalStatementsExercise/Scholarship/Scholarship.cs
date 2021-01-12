using System;

namespace Scholarship
{
    class Scholarship
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double mark = double.Parse(Console.ReadLine());
            double minWage = double.Parse(Console.ReadLine());

            double social = minWage * 0.35;
            double scholar = mark * 25;


            if (mark <= 4.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

            if (income > minWage) 
            { 
                if (mark < 5.50)
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
            }


            if (mark >= 5.50)
            {
                if (income >= minWage)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(scholar)} BGN");
                }
            }

            if (mark < 5.50)
            {
                if (income < minWage)
                {
                    if (mark > 4.50)
                    {
                        Console.WriteLine($"You get a Social scholarship {Math.Floor(social)} BGN");
                    }
                }
            }

            if (mark >= 5.50)
            {
                if (income < minWage)
                {
                    if (social > scholar)
                    {
                        Console.WriteLine($"You get a Social scholarship {Math.Floor(social)} BGN");
                    }
                    else
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(scholar)} BGN");
                    }

                }
            }

        }
    }
}
