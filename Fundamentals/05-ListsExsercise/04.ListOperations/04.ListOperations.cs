using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArg = command.Split().ToArray();

                if (cmdArg[0] == "Add")
                {
                    numbers.Add(int.Parse(cmdArg[1]));
                }

                if (cmdArg[0] == "Insert")
                {
                    if (int.Parse(cmdArg[2]) > numbers.Count || int.Parse(cmdArg[2]) < 0)
                    {
                        Console.WriteLine("Invalid index");                   
                    }
                    else
                    {
                        numbers.Insert(int.Parse(cmdArg[2]), int.Parse(cmdArg[1]));
                    }                                      
                }

                if (cmdArg[0] == "Remove")
                {
                    if (int.Parse(cmdArg[1]) > numbers.Count || int.Parse(cmdArg[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");                     
                    }
                    else
                    {
                        numbers.RemoveAt(int.Parse(cmdArg[1]));
                    }                   
                }

                if (cmdArg[1] == "left")
                {
                    for (int i = 0; i < int.Parse(cmdArg[2]); i++)
                    {
                        int firstElement = numbers[0];
                        
                        
                        for (int j = 0; j < numbers.Count - 1; j++)
                        {
                            numbers[j] = numbers[j + 1];
                        }

                        numbers[numbers.Count - 1] = firstElement;
                    }
                }

                if (cmdArg[1] == "right")
                {
                    for (int i = 0; i < int.Parse(cmdArg[2]); i++)
                    {

                        int lastElement = numbers[numbers.Count - 1];

                        for (int j = numbers.Count - 1; j > 0; j--)
                        {
                            numbers[j] = numbers[j - 1];
                        }

                        numbers[0] = lastElement;
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
