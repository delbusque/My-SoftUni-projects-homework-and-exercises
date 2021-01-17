using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> clothes = new Stack<int>(input);
            int rackValue = int.Parse(Console.ReadLine());

            int racks = 1;

            while (clothes.Count > 0)
            {
                int currRack = rackValue;

                while (currRack > 0 && clothes.Count > 0)
                {
                    if (clothes.Peek() <= currRack)
                    {
                        currRack -= clothes.Pop();
                        if (currRack == 0 && clothes.Count > 0)
                        {
                            racks++;
                            break;
                        }
                    }
                    else
                    {
                        racks++;
                        break;
                    }
                }
            }

            Console.WriteLine(racks);
        }
    }
}
