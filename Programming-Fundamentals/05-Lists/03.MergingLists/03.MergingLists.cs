using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            List<int> secondLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            List<int> comboLine = new List<int>();

            for (int i = 0; i < Math.Min(firstLine.Count, secondLine.Count); i++)
            {
                comboLine.Add(firstLine[i]);
                comboLine.Add(secondLine[i]);
            }

            for (int i = Math.Min(firstLine.Count, secondLine.Count); i < Math.Max(firstLine.Count, secondLine.Count); i++)
            {
                if (firstLine.Count > secondLine.Count)
                {
                    comboLine.Add(firstLine[i]);
                }
                else if (firstLine.Count < secondLine.Count)
                {
                    comboLine.Add(secondLine[i]);

                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(string.Join(" ", comboLine));
        }
    }
}
