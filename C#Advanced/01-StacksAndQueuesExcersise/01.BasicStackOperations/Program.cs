using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cmdArg = Console.ReadLine().Split();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < int.Parse(cmdArg[0]); i++)
            {
                stack.Push(numbers[i]);
            }

            if (stack.Count >= int.Parse(cmdArg[1]))
            {
                for (int i = 0; i < int.Parse(cmdArg[1]); i++)
                {
                    stack.Pop();
                }
            }
            else
            {
                int tempArg = stack.Count;
                
                for (int i = 0; i < tempArg; i++)
                {
                    stack.Pop();
                }
            }

            if (stack.Count > 0)
            {
                if (stack.Contains(int.Parse(cmdArg[2])))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(string.Join("", stack.Min()));
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
