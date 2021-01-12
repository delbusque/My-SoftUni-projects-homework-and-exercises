﻿using System;

namespace HalfSumElement
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNum = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                sum += num;

                if (num > maxNum)
                {
                    maxNum = num;                   
                }
            }

            int sumWithoutMaxNum = sum - maxNum;

            if (sumWithoutMaxNum == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNum}");
            }

            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNum - sumWithoutMaxNum)}");
            }

        }
    }
}
