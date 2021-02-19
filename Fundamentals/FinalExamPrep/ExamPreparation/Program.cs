using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawKey = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Generate")
            {
                string[] commandLine = input.Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                string command = commandLine[0];

                if (command == "Contains")
                {
                    if (rawKey.Contains(commandLine[1]))
                    {
                        Console.WriteLine($"{rawKey} contains {commandLine[1]}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }              

                else if (command == "Flip")
                {
                    string upperLower = commandLine[1];
                    int startIndex = int.Parse(commandLine[2]);
                    int endIndex = int.Parse(commandLine[3]);
                    string substringString = rawKey.Substring(startIndex, endIndex - startIndex);
                    char[] substrin = substringString.ToCharArray();

                    for (int i = 0; i < substrin.Length; i++)
                    {
                        if (upperLower == "Upper")
                        {                           
                            if (Char.IsLower(substrin[i]))
                            {
                                substrin[i] = Char.ToUpper(substrin[i]);
                            }
                        }
                        else if (upperLower == "Lower")
                        {
                            if (Char.IsUpper(substrin[i]))
                            {
                                substrin[i] = Char.ToLower(substrin[i]);
                            }
                        }                                            
                    }

                    substringString = new string(substrin);
                    rawKey = rawKey.Replace(rawKey.Substring(startIndex, endIndex-startIndex), substringString);

                    Console.WriteLine(rawKey);
                }

                else if (command == "Slice")
                {
                    int startIndex = int.Parse(commandLine[1]);
                    int endIndex = int.Parse(commandLine[2]);

                    rawKey = rawKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(rawKey);

                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {rawKey}");

        }
    }
}
