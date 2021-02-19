using System;

namespace GraduationPart2
{
    class GraduationPart2
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int level = 1;
            double sum = 0;

            while (level <= 12)
            {
                double mark = double.Parse(Console.ReadLine());

                if (mark >= 4)
                {
                    sum += mark;
                    level++;
                }

                else if (mark < 4)
                {
                    mark = double.Parse(Console.ReadLine());

                    if (mark < 4)
                    {
                        Console.WriteLine($"{name} has been excluded at {level} grade");
                        Environment.Exit(1);
                    }
                    else
                    {
                        sum += mark;
                        level++;
                    }
                }               
            }

            Console.WriteLine($"{name} graduated. Average grade: {sum / 12:f2}");
        }
    }
}
