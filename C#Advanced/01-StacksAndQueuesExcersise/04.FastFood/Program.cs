using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            int[] ordered = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> orders = new Queue<int>();
            foreach (var item in ordered)
            {
                orders.Enqueue(item);
            }

            Console.WriteLine(orders.Max());

            int counter = orders.Count;

            for (int i = 0; i < counter; i++)
            {
                if (food >= orders.Peek())
                {
                    food -= orders.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}"); 
            }            
        }
    }
}
