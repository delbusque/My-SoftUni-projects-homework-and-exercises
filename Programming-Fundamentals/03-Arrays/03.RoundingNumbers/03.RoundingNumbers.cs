using System;
using System.Linq;

namespace _03.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            int[] rounded = new int[numbers.Length];

            for (int i = 0; i < rounded.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    numbers[i] = 0;
                }               
                
                rounded[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{numbers[i]} => {rounded[i]}");
            }
            
        }
    }
}
