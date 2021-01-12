using System;

namespace Methods_Excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(SmallestNumber(a, b, c));
        }

        static int SmallestNumber(int a, int b, int c)
        {
            int minNumber = Math.Min(Math.Min(a, b), c);
            
            return minNumber;
        }
    }
}
