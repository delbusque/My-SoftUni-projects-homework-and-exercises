using System;
using System.Linq;

namespace _02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();

            foreach (var item2 in arr2)
            {
                foreach (var item1 in arr1)
                {
                    if (item1 == item2)
                    {
                        Console.Write(item2 + " ");
                    }
                }
            }
        }
    }
}
