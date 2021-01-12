using System;
using System.Linq;

namespace _07.EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arrayTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;

            for (int i = 0; i < arrayOne.Length; i++)
            {
                if (arrayOne[i] == arrayTwo[i])
                {
                    sum += arrayOne[i];                    
                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    Environment.Exit(0);
                }
            }

            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
