using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> book = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] cmdArg = Console.ReadLine().Split();

                if (!book.ContainsKey(cmdArg[0]))
                {
                    book.Add(cmdArg[0], new List<decimal>());
                    book[cmdArg[0]].Add(decimal.Parse(cmdArg[1]));
                }
                else
                {
                    book[cmdArg[0]].Add(decimal.Parse(cmdArg[1]));
                }
            }
            
            foreach (var item in book)
            {
                Console.WriteLine($"{item.Key} -> {string.Join(" ", item.Value.Select(v => v.ToString("f2")))} (avg: {item.Value.Average():f2})");
            }
        }
    }
}
