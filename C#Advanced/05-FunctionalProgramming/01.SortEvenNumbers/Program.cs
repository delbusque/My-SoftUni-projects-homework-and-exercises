using System;
using System.Linq;

namespace _01.SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ").Select(int.Parse)
                .Where(x => x % 2 == 0).OrderBy(i => i);

            Console.WriteLine(string.Join(", ", input));
        }
    }
}
