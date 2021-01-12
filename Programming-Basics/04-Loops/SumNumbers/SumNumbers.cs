using System;

namespace SumNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= count; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                sum = sum + currentNum;
            }

            Console.WriteLine(sum);
        }
    }
}
