using System;

namespace _10.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                sum = n * i;

                Console.WriteLine($"{n} X {i} = {sum}");
            }
        }
    }
}
