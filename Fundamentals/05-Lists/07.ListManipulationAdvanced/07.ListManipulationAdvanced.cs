using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            bool isChanged = false;

            while (command[0].ToLower() != "end")
            {

                switch (command[0].ToLower())
                {
                    case "add":
                        list.Add(int.Parse(command[1]));
                        isChanged = true;
                        break;

                    case "remove":
                        list.Remove(int.Parse(command[1]));
                        isChanged = true;
                        break;

                    case "removeat":
                        list.RemoveAt(int.Parse(command[1]));
                        isChanged = true;
                        break;

                    case "insert":
                        list.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        isChanged = true;
                        break;

                    //case "contains":
                    //    Console.WriteLine(list.Contains(int.Parse(command[1])) ? "Yes" : "No such number");
                    //   break;

                    case "contains":
                        if (list.Contains(int.Parse(command[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;

                    case "printeven":
                        Console.WriteLine(string.Join(" ", list.Where(n => n % 2 == 0)));
                        break;

                    case "printodd":
                        Console.WriteLine(string.Join(" ", list.Where(n => n % 2 != 0)));
                        break;

                    case "getsum":
                        Console.WriteLine(list.Sum());
                        break;

                    case "filter":

                        switch (command[1])
                        {
                            case ">":
                                Console.WriteLine(string.Join(" ", list.Where(n => n > int.Parse(command[2]))));
                                break;

                            case ">=":
                                Console.WriteLine(string.Join(" ", list.Where(n => n >= int.Parse(command[2]))));
                                break;

                            case "<":
                                Console.WriteLine(string.Join(" ", list.Where(n => n < int.Parse(command[2]))));
                                break;

                            case "<=":
                                Console.WriteLine(string.Join(" ", list.Where(n => n <= int.Parse(command[2]))));
                                break;
                        }
                        break;
                }

                command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }


            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", list));
            }

        }
    }
}
