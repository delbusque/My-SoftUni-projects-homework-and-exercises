using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries_Exsercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Dictionary<char, int> characters = new Dictionary<char, int>();

            foreach (var item in input)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (!characters.ContainsKey(item[i]))
                    {
                        characters.Add(item[i], 1);
                    }
                    else
                    {
                        characters[item[i]]++;
                    }
                }
            }

            foreach (var ch in characters)
            {
                Console.WriteLine($"{ch.Key} -> {ch.Value}");
            }
        }
    }
}
