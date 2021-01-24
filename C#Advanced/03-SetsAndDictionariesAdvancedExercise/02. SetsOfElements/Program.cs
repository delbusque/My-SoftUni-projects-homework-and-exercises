using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] param = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> setA = new HashSet<int>();
            HashSet<int> setB = new HashSet<int>();

            for (int i = 0; i < param[0]; i++)
            {
                setA.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < param[1]; i++)
            {
                setB.Add(int.Parse(Console.ReadLine()));
            }

            setA.IntersectWith(setB);

            Console.Write(string.Join(" ", setA)); 
        }
    }
}
