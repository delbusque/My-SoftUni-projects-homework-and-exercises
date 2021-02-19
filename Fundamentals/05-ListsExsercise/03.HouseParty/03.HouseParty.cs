using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string[] cmdArg = command.Split().ToArray();
                string name = cmdArg[0];             
                
                if (cmdArg.Length == 3)
                {
                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }

                    guests.Add(name);
                }
                else
                {
                    if (!guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }

                    guests.Remove(name);         
                }

            }

            Console.WriteLine(string.Join(Environment.NewLine, guests));
        }
    }
}
