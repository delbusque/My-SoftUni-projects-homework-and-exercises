using System;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();  // 27 19 42 2 13 45 48

            for (int i = 0; i < array.Length; i++)
            {
                bool check = true;

                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] <= array[j])
                    {
                        check = false;
                        break;
                    }
                }

                if (check)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
}
