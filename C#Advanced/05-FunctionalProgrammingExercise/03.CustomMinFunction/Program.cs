using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Func<int[], int> minFunc = num => num.Min();

            int[] numbs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(minFunc(numbs));
        }

    }
}
