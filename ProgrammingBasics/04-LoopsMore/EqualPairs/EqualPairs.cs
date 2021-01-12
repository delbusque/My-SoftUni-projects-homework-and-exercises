using System;

namespace EqualPairs
{
    class EqualPairs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentSum = 0;
            int previoSum = 0;
            int diff = 0;
            int maxDiff = 0;
           
            for (int i = 1; i <= n; i++)
            {
                previoSum = currentSum;
                currentSum = 0;

                currentSum += int.Parse(Console.ReadLine());
                currentSum += int.Parse(Console.ReadLine());

                if (i != 1)
                {
                    diff = Math.Abs(currentSum - previoSum);

                    if (diff != 0 && diff > maxDiff)
                    {
                        maxDiff = diff;
                    }
                }

            }
            if (previoSum == currentSum || n == 1)
            {
                Console.WriteLine($"Yes, value={currentSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
