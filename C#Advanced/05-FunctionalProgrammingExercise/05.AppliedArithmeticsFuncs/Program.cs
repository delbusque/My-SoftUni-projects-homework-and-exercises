using System;
using System.Linq;

namespace _05.AppliedArithmeticsFuncs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();            
            string command = Console.ReadLine();

            Func<int, int> addFunc = n => n += 1;
            Func<int, int> multiplyFunc = n => n *= 2;
            Func<int, int> subtractFunc = n => n -= 1;

            while (command != "end")
            {
                if (command == "add")
                {
                    numbers = numbers.Select(addFunc).ToArray();
                }
                else if (command == "multiply")
                {
                    numbers = numbers.Select(multiplyFunc).ToArray();
                }
                else if (command == "subtract")
                {
                    numbers = numbers.Select(subtractFunc).ToArray();
                }
                else if (command == "print")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                }

                command = Console.ReadLine();
            }
        }
    }
}
