using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;


namespace R._01.SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            
            string[] cmdArg = Console.ReadLine().Split(":|:");

            while (cmdArg[0] != "Reveal")
            {
                string command = cmdArg[0];

                if (command == "InsertSpace")
                {
                    int index = int.Parse(cmdArg[1]);

                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }

                else if (command == "Reverse")
                {
                    string subString = cmdArg[1];
                    
                  
                    if (message.Contains(subString))
                    {
                        char[] chSubString = subString.ToCharArray(); 
                        Array.Reverse(chSubString);

                        int index = message.IndexOf(subString);
                        message = message.Remove(index, subString.Length);
                        string revMessage = string.Join("", chSubString);

                        message += revMessage;

                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }

                else if (command == "ChangeAll")
                {
                    string subString = cmdArg[1];
                    string replacement = cmdArg[2];

                    if (message.Contains(subString))
                    {
                        message = message.Replace(subString, replacement);
                    }

                    Console.WriteLine(message);
                }

                cmdArg = Console.ReadLine().Split(":|:");
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
