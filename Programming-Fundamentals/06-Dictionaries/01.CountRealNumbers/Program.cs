using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(nu => int.Parse(nu)).ToArray();

            SortedDictionary<int, int> numDictionary = new SortedDictionary<int, int>();

            foreach (var num in numbers)
            {
                if (!numDictionary.ContainsKey(num))
                {
                    numDictionary.Add(num, 1);
                }
                else
                {
                    numDictionary[num]++;
                }
            }

            foreach (var item in numDictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
