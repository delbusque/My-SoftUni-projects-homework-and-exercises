using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.GenericSwapMethodString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            MyList<string> list = new MyList<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                list.Values.Add(input);
            }

            int[] swap = Console.ReadLine().Split().Select(int.Parse).ToArray();

            list.Swap(swap[0], swap[1]);

            Console.WriteLine(list);

        }
    }
}
