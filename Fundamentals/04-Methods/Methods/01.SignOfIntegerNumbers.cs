using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int numInput = int.Parse(Console.ReadLine());

            PrintSign(numInput);
        }

        static void PrintSign(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }

            else if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }

            else
            {
                Console.WriteLine($"The number {num} is zero.");
            }
        }
    }
}
