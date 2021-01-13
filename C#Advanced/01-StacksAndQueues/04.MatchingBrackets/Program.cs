using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();  //          1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5
            Stack<int> brackets = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
             
                if (input[i] == '(')
                {
                    brackets.Push(i);
                }
                else if (input[i] == ')')
                {
                    int start = brackets.Pop();
                    Console.WriteLine(input.Substring(start, i - start + 1));
                }
            }
        }
    }
}
