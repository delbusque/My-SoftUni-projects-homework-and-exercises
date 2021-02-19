using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceBook = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();                        // Darker | DCay
            
                                                                        // Ivan Ivanov -> Lighter
            while (command != "Lumpawaroo")
            {
                List<string> cmdArgs = command.Split().ToList();
                string[] cmdCheck;
                string[] cmdChange;

                if (cmdArgs.Contains("|"))
                {
                    cmdCheck = command.Split(" | ");
                    string name = cmdCheck[1];
                    string side = cmdCheck[0];

                    if (!forceBook.ContainsKey(side))
                    {
                        forceBook.Add(side, new List<string>());
                        forceBook[side].Add(name);
                    }
                    else
                    {
                        forceBook[side].Add(name);
                    }

                }

                else if (cmdArgs.Contains("->"))
                {
                    cmdChange = command.Split(" -> ");
                    string name = cmdChange[0];
                    string side = cmdChange[1];

                    if (!forceBook.ContainsKey(side))
                    {
                        forceBook.Add(side, new List<string>());
                        forceBook[side].Add(name);
                    }

                    forceBook.

                    if (forceBook.ContainsValue(cmdArgs))
                    {
                        forceBook[side].Add(name);
                    }

                }

                


                command = Console.ReadLine();
            }
        }
    }
}
