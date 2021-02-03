using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string band = Console.ReadLine();

            List<int> numbers = new List<int>();
            for (int i = input[0]; i <= input[1]; i++)
            {
                numbers.Add(i);
            }

            Func<List<int>, string, List<int>> comparer = oddEven;
            Console.WriteLine(string.Join(" ", comparer(numbers, band))); 
        }

        static List<int> oddEven(List<int> numbers, string band)
        {
            switch (band)
            {
                case "even":
                    List<int> result = new List<int>();
                    foreach (var item in numbers)
                    {
                        if (item % 2 == 0)
                        {
                            result.Add(item);
                        }
                    }
                    return result;

                case "odd":
                    List<int> oddResult = new List<int>();

                    foreach (var item in numbers)
                    {
                        if (item % 2 != 0)
                        {
                            oddResult.Add(item);
                        }
                    }
                    return oddResult;

                default:
                    return null;
            }

        }
    }
}
