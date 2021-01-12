using System;

namespace PipesInPool
{
    class PipesInPool
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int tubeA = int.Parse(Console.ReadLine());
            int tubeB = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double debitTubeA = tubeA * hours;
            double debitTubeB = tubeB * hours;
            double totalDebit = debitTubeA + debitTubeB;

            if (capacity >= totalDebit)
            {
                double DebitPercentage = totalDebit / capacity * 100;
                double TubeAPercentage = debitTubeA / totalDebit * 100;
                double TubeBPercentage = debitTubeB / totalDebit * 100;

                Console.WriteLine($"The pool is {DebitPercentage:f2}% full. Pipe 1: {TubeAPercentage:f2}%. Pipe 2: {TubeBPercentage:f2}%.");
            }
            else if (capacity < totalDebit)
            {
                double overflow = totalDebit - capacity;
                Console.WriteLine($"For {hours} hours the pool overflows with {overflow:f2} liters.");
            }


        }
    }
}
