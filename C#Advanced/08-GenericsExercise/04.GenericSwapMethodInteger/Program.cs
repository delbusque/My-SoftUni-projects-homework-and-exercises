using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.GenericSwapMethodInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            MyList<int> list = new MyList<int>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                list.Values.Add(int.Parse(input));
            }

            int[] swap = Console.ReadLine().Split().Select(int.Parse).ToArray();

            list.Swap(swap[0], swap[1]);

            Console.WriteLine(list);

        }
    }
}
