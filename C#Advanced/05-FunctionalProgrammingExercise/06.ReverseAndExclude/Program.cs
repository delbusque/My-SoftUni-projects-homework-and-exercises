using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();

            int numb = int.Parse(Console.ReadLine());
            
            Predicate<int> divisible = n => n % numb == 0;
            input.RemoveAll(divisible);

            Console.WriteLine(string.Join(" ", input));
        }   
    }
}
