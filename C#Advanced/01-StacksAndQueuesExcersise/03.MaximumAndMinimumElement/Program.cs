using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            short nQueries = short.Parse(Console.ReadLine());

            for (int i = 0; i < nQueries; i++)
            {
                short[] currQuerie = Console.ReadLine().Split().Select(short.Parse).ToArray();

                switch (currQuerie[0])
                {
                    case 1:
                        stack.Push(currQuerie[1]);
                        break;
                    case 2:
                        stack.Pop();
                        break;
                    case 3:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;
                    case 4:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
