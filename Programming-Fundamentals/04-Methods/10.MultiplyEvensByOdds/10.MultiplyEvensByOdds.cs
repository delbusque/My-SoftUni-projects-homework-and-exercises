using System;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            num = Math.Abs(num);

            int oddSum = OddSum(num);
            int evenSum = EvenSum(num);

            int multiplySum = Multiply(oddSum, evenSum);
            Console.WriteLine(multiplySum);

        }

        private static int Multiply(int oddSum, int evenSum)
        {
            return oddSum * evenSum;
        }

        private static int EvenSum(int num)
        {
            string numStr = num.ToString();
            int evenSum = 0;

            for (int i = 0; i < numStr.Length; i++)
            {
                int currentDigit = int.Parse(numStr[i].ToString());
                if (currentDigit % 2 == 0)
                {
                    evenSum += currentDigit;
                }
            }
            return evenSum;
        }

        static int OddSum(int num)
        {
            string numStr = num.ToString();
            int oddSum = 0;

            for (int i = 0; i < numStr.Length; i++)
            {
                int currentDigit = int.Parse(numStr[i].ToString());
                if (currentDigit % 2 != 0)
                {
                    oddSum += currentDigit;
                }
            }

            return oddSum;
        }

    }
}


