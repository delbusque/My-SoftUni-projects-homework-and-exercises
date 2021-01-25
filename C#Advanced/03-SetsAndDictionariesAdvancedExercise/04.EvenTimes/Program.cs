﻿using System;
using System.Collections.Generic;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int currNumb = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(currNumb))
                {
                    numbers.Add(currNumb, 1);
                }
                else
                {
                    numbers[currNumb]++;
                }
            }

            foreach (var item in numbers)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                    Environment.Exit(0);
                }
            }         
        }
    }
}
