using System;
using System.Collections.Generic;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] currLine = Console.ReadLine().Split();

                for (int j = 0; j < currLine.Length; j++)
                {
                    elements.Add(currLine[j]);
                }
            }

            Console.Write(string.Join(" ", elements));
        }
    }
}
