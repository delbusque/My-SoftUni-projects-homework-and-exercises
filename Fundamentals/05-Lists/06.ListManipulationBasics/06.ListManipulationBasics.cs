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

            string command = Console.ReadLine();
            
            while (command != "end")
            {
                string[] currentLine = command.Split();
                int number = 0;
                int index = 0;
                

                switch (currentLine[0])
                {
                    case "Add":
                        number = int.Parse(currentLine[1]);
                        list.Add(number);
                        break;

                    case "Remove":
                        number = int.Parse(currentLine[1]);
                        list.Remove(number);
                        break;

                    case "RemoveAt":
                        index = int.Parse(currentLine[1]);
                        list.RemoveAt(index);
                        break;

                    case "Insert":
                        number = int.Parse(currentLine[1]);
                        index = int.Parse(currentLine[2]);
                        list.Insert(index, number);
                        break;

                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
