using System;

namespace _01.ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split();

            Action<string[]> printNames = n => Console.WriteLine(string.Join($"{Environment.NewLine}", n));

            printNames(names);
            
        }
    }
}
