﻿using System;

namespace DataTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            double km = meters * 0.001;

            Console.WriteLine($"{km:f2}"); ;
        }
    }
}
