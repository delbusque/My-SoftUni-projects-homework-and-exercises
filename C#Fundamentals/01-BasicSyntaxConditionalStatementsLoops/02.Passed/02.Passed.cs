using System;

namespace _02.Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            double mark = double.Parse(Console.ReadLine());

            if (mark >= 3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
