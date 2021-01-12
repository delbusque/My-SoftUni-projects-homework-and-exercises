
using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        

        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmdArg = command.Split().ToArray();
                string currCommand = cmdArg[0];
                int element = int.Parse(cmdArg[1]);

                if (currCommand == "Delete")
                {
                    
                    numbers.RemoveAll(f => f == element);
                }

                if (currCommand == "Insert")
                {
                    numbers.Insert(int.Parse(cmdArg[2]), element);
                }

             command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
