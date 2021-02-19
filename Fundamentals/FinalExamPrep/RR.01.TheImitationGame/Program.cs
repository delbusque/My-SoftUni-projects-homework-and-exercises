using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RR._01.TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> message = new List<char>();
            
            for (int i = 0; i < input.Length; i++)
            {
                message.Add(input[i]);
            }

            string[] cmdArgs = Console.ReadLine().Split("|");

            while (cmdArgs[0] != "Decode")
            {
                string command = cmdArgs[0];

                if (command == "Move")
                {
                    int nLetters = int.Parse(cmdArgs[1]);

                    for (int i = 0; i < nLetters; i++)
                    {
                        message.Add(message[i]);                        
                    }
                        
                    message.RemoveRange(0, nLetters);

                }

                else if (command == "Insert")
                {
                    int inputIndex = int.Parse(cmdArgs[1]);
                    
                    int index = inputIndex; 
                    string value = cmdArgs[2];

                    message.InsertRange(index, value);
                }

                else if (command == "ChangeAll")
                {
                    string subString = cmdArgs[1];
                    string replacement = cmdArgs[2];

                    StringBuilder stringMessage = new StringBuilder();

                    for (int i = 0; i < message.Count; i++)
                    {
                        stringMessage.Append(message[i]);
                    }

                    stringMessage = stringMessage.Replace(subString, replacement);

                    string newmessage = stringMessage.ToString();
                    message = newmessage.ToList();

                }


                cmdArgs = Console.ReadLine().Split("|");
            }

            Console.WriteLine($"The decrypted message is: {string.Join("", message)}");
        }
    }
}
