using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_Exsercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();

            int wagCapacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            


            while (command != "end")
            {
                string[] cmdArg = command.Split().ToArray();

                if (cmdArg[0] == "Add")
                {
                    wagons.Add(int.Parse(cmdArg[1]));
                }

                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (int.Parse(cmdArg[0]) + wagons[i] <= wagCapacity)
                        {
                            wagons[i] += int.Parse(cmdArg[0]);
                            break;
                        }
                    }    
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
