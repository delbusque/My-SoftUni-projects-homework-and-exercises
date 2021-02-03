using System;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int[], string, int[]> apllied = Arithmetics;

            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command == "print")
                {
                    Console.WriteLine(string.Join(" ", apllied(numbers, command)));
                }
                else
                {
                    apllied(numbers, command);
                }

                command = Console.ReadLine();

            }


        }

        static int[] Arithmetics(int[] numbers, string command)
        {
            int[] result = numbers;

            switch (command)
            {
                case "add":
                    for (int i = 0; i < result.Length; i++)
                    {
                        result[i] += 1;
                    }
                    return result;

                case "multiply":
                    for (int i = 0; i < result.Length; i++)
                    {
                        result[i] *= 2;
                    }
                    return result;

                case "subtract":
                    for (int i = 0; i < result.Length; i++)
                    {
                        result[i] -= 1;
                    }
                    return result;

                case "print":
                    return result;

                default:
                    return null;
            }
        }
    }
}


