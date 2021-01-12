using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputLine = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            for (int i = 0; i < inputLine.Count; i++)
            {
                if (inputLine[i] < 0)
                {
                    inputLine.RemoveAt(i);
                    i = -1;
                }
            }

            inputLine.Reverse();

            if (inputLine.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(' ', inputLine));
            }
        }
    }
}
