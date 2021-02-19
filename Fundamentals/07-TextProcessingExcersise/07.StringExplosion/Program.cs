using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            decimal totalSum = 0m;

            foreach (var str in input)
            {
                decimal sum = 0m;

                char[] current = str.ToCharArray();
                decimal number = decimal.Parse(str.Substring(1, str.Length - 2));

                if (current[0] >= 65 && current[0] <= 90)
                {
                    sum += number / (current[0] - 64);
                }
                else if (current[0] >= 97 && current[0] <= 122)
                {
                    sum += number * (current[0] - 96);
                }

                if (current[str.Length-1] >= 65 && current[str.Length - 1] <= 90)
                {
                    sum -= current[str.Length - 1] - 64;
                }
                else if (current[str.Length - 1] >= 97 && current[str.Length - 1] <= 122)
                {
                    sum += current[str.Length - 1] - 96;
                }

                totalSum += sum;

            }

            Console.WriteLine($"{totalSum:f2}");
        
        }
    }
}
