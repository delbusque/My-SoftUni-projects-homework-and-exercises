using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(input);

            string[] command = Console.ReadLine().Split();

            while (command[0].ToLower() != "end")
            {
                if (command[0].ToLower() == "add")
                {
                    stack.Push(int.Parse(command[1]));
                    stack.Push(int.Parse(command[2]));
                }

                else if (command[0].ToLower() == "remove")
                {
                    if (stack.Count >= int.Parse(command[1]))
                    {
                        for (int i = 0; i < int.Parse(command[1]); i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                command = Console.ReadLine().Split();
            }

            int sum = 0;

            foreach (var item in stack)
            {
                sum += item;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
