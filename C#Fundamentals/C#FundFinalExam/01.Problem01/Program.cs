using System;
using System.Text;
using System.Linq;
using System.Numerics;

namespace FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string skill = Console.ReadLine();

            string commandInput = Console.ReadLine();

            while (commandInput != "For Azeroth")
            {
                string[] cmdArgs = commandInput.Split();

                if (cmdArgs[0] == "GladiatorStance")
                {
                    skill = skill.ToUpper();
                    Console.WriteLine(skill);
                }

                else if (cmdArgs[0] == "DefensiveStance")
                {
                    skill = skill.ToLower();
                    Console.WriteLine(skill);
                }

                else if (cmdArgs[0] == "Dispel")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string letter = cmdArgs[2];

                    if (index > skill.Length-1 || index < 0)
                    {
                        Console.WriteLine("Dispel too weak.");
                    }
                    else
                    {
                        skill = skill.Insert(index, letter);
                        skill = skill.Remove(index + 1, 1);
                        Console.WriteLine("Success!");
                    }

                }

                else if (cmdArgs[0] == "Target" && cmdArgs[1] == "Change")
                {
                    string substring = cmdArgs[2];
                    string secondSubstring = cmdArgs[3];

                    skill = skill.Replace(substring, secondSubstring);
                    Console.WriteLine(skill);
                }

                else if (cmdArgs[0] == "Target" && cmdArgs[1] == "Remove")
                {
                    string substring = cmdArgs[2];
                    StringBuilder skills = new StringBuilder();
                    skills.Append(skill);
                    skills.Replace(substring, null);
                    skill = skills.ToString();
                    Console.WriteLine(skill);
                }

                else
                {
                    Console.WriteLine("Command doesn't exist!");
                }


                commandInput = Console.ReadLine();
            }
        }
    }
}
