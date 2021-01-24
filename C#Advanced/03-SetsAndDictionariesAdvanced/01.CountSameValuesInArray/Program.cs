using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> values = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!values.ContainsKey(input[i]))
                {
                    values.Add(input[i], 1);
                }
                else
                {
                    values[input[i]]++;
                }
            }

            foreach (var item in values)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
