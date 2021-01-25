using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            SortedDictionary<char, int> listed = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!listed.ContainsKey(text[i]))
                {
                    listed.Add(text[i], 1);
                }
                else
                {
                    listed[text[i]]++;
                }
            }

            foreach (var item in listed)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
