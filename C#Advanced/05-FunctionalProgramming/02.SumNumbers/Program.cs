using System;
using System.Linq;

namespace _02.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Counter(input);
            Sumer(input);
        }

        static int Count(int[] numbers)
        {
            int result = numbers.Length;
            return result;
        }
        static int Sum(int[] numbers)
        {
            int result = numbers.Sum();
            return result;
        }

        static void Counter(int[] numbers)
        {
            int result = numbers.Length;
            Console.WriteLine(result);
        }
        static void Sumer(int[] numbers)
        {
            int result = numbers.Sum();
            Console.WriteLine(result);
        }
    }
}
