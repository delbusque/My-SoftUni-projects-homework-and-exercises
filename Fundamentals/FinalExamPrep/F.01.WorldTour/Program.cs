using System;

namespace F._01.WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStops = Console.ReadLine();
            //string stops = string.Empty;

            string[] cmdArgs = Console.ReadLine().Split(":");

            while (cmdArgs[0] != "Travel")
            {
                string command = cmdArgs[0];

                if (command == "Add Stop")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string toInsert = cmdArgs[2];

                    if (inputStops.Length-1 >= index)
                    {
                        inputStops = inputStops.Insert(index, toInsert);
                    }

                    Console.WriteLine(inputStops);
                }

                else if (command == "Remove Stop")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);

                    if (startIndex <= endIndex && endIndex <= inputStops.Length-1)
                    {
                        int count = endIndex + 1 - startIndex;

                        inputStops = inputStops.Remove(startIndex, count);
                    }

                    Console.WriteLine(inputStops);

                }

                else if (command == "Switch")
                {
                    string oldString = cmdArgs[1];
                    string newString = cmdArgs[2];

                    if (inputStops.Contains(oldString))
                    {
                        inputStops = inputStops.Replace(oldString, newString);   
                    }

                    Console.WriteLine(inputStops);
                }

                cmdArgs = Console.ReadLine().Split(":");

            }

            Console.WriteLine($"Ready for world tour! Planned stops: {inputStops}");
        }
    }
}
