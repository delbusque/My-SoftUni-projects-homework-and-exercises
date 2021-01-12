using System;

namespace Graduation
{
    class Graduation
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double sum = 0;
            int level = 1;

            while (level <= 12)
            {
                double mark = double.Parse(Console.ReadLine());

                if (mark >= 4)
                {
                    level++;
                    sum += mark;
                }
                
                else
                {
                    continue;
                }
            }

            Console.WriteLine($"{name} graduated. Average grade: {sum / 12:f2}");
            
        }
    }
}
