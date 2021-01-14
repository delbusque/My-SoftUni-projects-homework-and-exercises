using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> reversed = new Stack<char>();

            foreach (var item in input)
            {
                reversed.Push(item);
            }

            while (reversed.Count > 0)

            {
                Console.Write(reversed.Pop());
            }
        }
    }
}
