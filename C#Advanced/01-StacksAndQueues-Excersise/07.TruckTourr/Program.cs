using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _08.BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPumps = int.Parse(Console.ReadLine());

            Queue<int[]> pumps = new Queue<int[]>();

            for (int i = 0; i < numberOfPumps; i++)
            {
                string pumpInput = $"{Console.ReadLine()} {i}";
                int[] pump = pumpInput.Split().Select(int.Parse).ToArray();

                pumps.Enqueue(pump);
            }

            var tank = 0;

            for (int i = 0; i < numberOfPumps; i++)
            {
                int[] currPump = pumps.Peek();
                tank += currPump[0];

                if (tank >= currPump[1])
                {
                    tank -= currPump[1];
                    pumps.Enqueue(pumps.Dequeue());
                }
                else
                {
                    pumps.Enqueue(pumps.Dequeue());
                    tank = 0;
                    i = -1;
                }
            }

            int[] thePump = pumps.Peek();
            Console.WriteLine(string.Join("", thePump[2]));
        }
    }
}
