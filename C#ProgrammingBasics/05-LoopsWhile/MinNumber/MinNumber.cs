using System;

namespace MinNumber
{
    class MinNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int minCurrent = int.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                int current = int.Parse(Console.ReadLine());

                if (current <= minCurrent)
                {
                    minCurrent = current;
                }
            }

            Console.WriteLine(minCurrent);
        }
    }
}
