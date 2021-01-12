using System;

namespace OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 1; i <= count; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += currentNum;
                }
                else
                {
                    oddSum += currentNum;
                }

            }

            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {oddSum}");
            }
            else
            {
                int more = Math.Abs(evenSum - oddSum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {more}");
            }
        }
    }
}
