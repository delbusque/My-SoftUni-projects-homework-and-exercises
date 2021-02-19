using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace _04._1.PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawPassword = Console.ReadLine(); 
            string[] input = Console.ReadLine().Split();
            

            while (input[0] != "Done")
            {
                string command = input[0];

                if (command == "TakeOdd")
                {
                    string oddRaw = string.Empty;
                    
                    for (int i = 1; i < rawPassword.Length; i+=2)
                    {
                        oddRaw = string.Concat(oddRaw, rawPassword[i]);
                    }

                    rawPassword = oddRaw;
                    Console.WriteLine(rawPassword);
                }

                else if (command == "Cut")
                {
                    int index = int.Parse(input[1]);
                    int lenght = int.Parse(input[2]);

                    rawPassword = rawPassword.Remove(index, lenght);
                    Console.WriteLine(rawPassword);
                }

                else if (command == "Substitute")
                {
                    string substringToRemove = input[1];
                    string newSubstring = input[2];

                    if (rawPassword.Contains(substringToRemove))
                    {
                        while (rawPassword.Contains(substringToRemove))
                        {
                            int startIndex = rawPassword.IndexOf(substringToRemove);
                            rawPassword = rawPassword.Remove(startIndex, substringToRemove.Length);
                            rawPassword = rawPassword.Insert(startIndex, newSubstring);
                        }
 
                        Console.WriteLine(rawPassword);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }

                input = Console.ReadLine().Split();
            }

            Console.WriteLine($"Your password is: {rawPassword}");
        }
    }
}
