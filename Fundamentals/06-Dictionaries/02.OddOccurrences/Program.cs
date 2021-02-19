using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split();

            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach (var item in input)
            {
                if (!words.ContainsKey(item))
                {
                    words.Add(item, 1);
                }
                else
                {
                    words[item]++;
                }
            }

            Dictionary<string, int> oddExistence = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (word.Value % 2 != 0)
                {
                    oddExistence.Add(word.Key, word.Value);
                }
            }

            Console.WriteLine(string.Join(" ", oddExistence.Keys));

        }
    }
}
