using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOddsWithPredicate
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

            Predicate<int> isEven = num => num % 2 == 0;

            if (band == "odd")
            {
                numbers.RemoveAll(isEven);
            }
            else if (band == "even")
            {
                numbers.RemoveAll( n => !isEven(n));
            }

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
