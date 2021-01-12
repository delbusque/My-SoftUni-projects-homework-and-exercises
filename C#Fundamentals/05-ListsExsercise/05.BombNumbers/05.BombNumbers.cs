using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();                    // 1 7 7 1 2 3

            string[] cmdArg = command.Split().ToArray();
            int bomb = int.Parse(cmdArg[0]);                        // 7
            int power = int.Parse(cmdArg[1]);                       // 1

            for (int i = 0; i < numbers.Count; i++)
            {

                int currentNumber = numbers[i];
                
                if (currentNumber == bomb)
                {
                    int start = i - power;
                    int end = i + power;

                    if (start < 0)
                    {
                        start = 0;
                    }
                    if (end > numbers.Count-1)
                    {
                        end = numbers.Count - 1;
                    }

                    numbers.RemoveRange(start, end - start + 1);

                    i = start - 1;
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
