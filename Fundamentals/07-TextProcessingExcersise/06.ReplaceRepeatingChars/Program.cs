using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<char> result = new List<char>();
            result.Add(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i-1])
                {
                    continue;
                }
                else
                {
                    result.Add(input[i]);
                }
            }

            Console.WriteLine(string.Join("", result));

        }
    }
}
