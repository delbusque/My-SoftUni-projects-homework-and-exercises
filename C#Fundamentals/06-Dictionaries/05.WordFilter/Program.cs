﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().Where(w => w.Length % 2 == 0).ToArray();

            foreach (var item in input)
            {
                Console.WriteLine(item);
            }

        }
    }
}
