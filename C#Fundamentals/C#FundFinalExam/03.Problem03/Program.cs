using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> heroes = new Dictionary<string, List<string>>();

            string[] cmdArgs = Console.ReadLine().Split();

            while (cmdArgs[0] != "End")
            {
                string command = cmdArgs[0];
                string heroName = cmdArgs[1];

                if (command  == "Enroll")
                {
                    if (heroes.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} is already enrolled.");
                    }
                    else
                    {
                        heroes.Add(heroName, new List<string>());
                        
                    }
                }

                else if (command == "Learn")
                {
                    string spell = cmdArgs[2];

                    if (!heroes.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                    else
                    {
                        if (heroes[heroName].Contains(spell))
                        {
                            Console.WriteLine($"{heroName} has already learnt {spell}.");
                        }
                        else
                        {
                            heroes[heroName].Add(spell);
                        }
                    }
                }

                else if (command == "Unlearn")
                {
                    string spell = cmdArgs[2];

                    if (!heroes.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                    else
                    {
                        if (!heroes[heroName].Contains(spell))
                        {
                            Console.WriteLine($"{heroName} doesn't know {spell}.");
                        }
                        else
                        {
                            while (heroes[heroName].Contains(spell))
                            {
                                heroes[heroName].Remove(spell);
                            }              
                        }
                    }
                }

                cmdArgs = Console.ReadLine().Split();
            }

            Console.WriteLine("Heroes:");

            foreach (var item in heroes.OrderByDescending(h=>h.Value.Count).ThenBy(h=>h.Key))
            {
                Console.WriteLine($"== {item.Key}: {string.Join(", ", item.Value)}");
            }
        }
    }
}
