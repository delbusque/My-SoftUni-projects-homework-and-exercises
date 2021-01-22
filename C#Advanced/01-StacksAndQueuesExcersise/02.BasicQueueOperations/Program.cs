using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cmdArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> que = new Queue<int>();

            for (int i = 0; i < cmdArgs[0]; i++)
            {
                que.Enqueue(elements[i]);
            }

            if (que.Count >= cmdArgs[1])
            {
                for (int i = 0; i < cmdArgs[1]; i++)
                {
                    que.Dequeue();
                }
            }
            else
            {
                int tempCount = que.Count;
                
                for (int i = 0; i < tempCount; i++)
                {
                    que.Dequeue();
                }
            }

            if (que.Count > 0)
            {
                if (que.Contains(cmdArgs[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(string.Join("", que.Min()));
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
