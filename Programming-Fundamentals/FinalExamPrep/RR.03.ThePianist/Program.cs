using System;
using System.Collections.Generic;
using System.Linq;

namespace RR._03.ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> pieces = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string[] initialPieces = Console.ReadLine().Split("|");
                pieces.Add(initialPieces[0], new List<string>());
                pieces[initialPieces[0]].Add(initialPieces[1]);
                pieces[initialPieces[0]].Add(initialPieces[2]);
            }

            string[] cmdArgs = Console.ReadLine().Split("|");

            while (cmdArgs[0] != "Stop")
            {
                string command = cmdArgs[0];
                string currentPiece = cmdArgs[1];

                if (command == "Add")
                {
                    string composer = cmdArgs[2];
                    string key = cmdArgs[3];

                    if (!pieces.ContainsKey(currentPiece))
                    {
                        pieces.Add(currentPiece, new List<string>());
                        pieces[currentPiece].Add(composer);
                        pieces[currentPiece].Add(key);
                        Console.WriteLine($"{currentPiece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{currentPiece} is already in the collection!");
                    }
                }

                else if (command == "Remove")
                {
                    if (pieces.ContainsKey(currentPiece))
                    {
                        pieces.Remove(currentPiece);
                        Console.WriteLine($"Successfully removed {currentPiece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {currentPiece} does not exist in the collection.");
                    }
                }

                else if (command == "ChangeKey")
                {
                    string newKey = cmdArgs[2];

                    if (pieces.ContainsKey(currentPiece))
                    {
                        pieces[currentPiece][1] = newKey.ToString();
                        Console.WriteLine($"Changed the key of {currentPiece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {currentPiece} does not exist in the collection.");
                    }
                }

                cmdArgs = Console.ReadLine().Split("|");
            }

            foreach (var item in pieces.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value[0]}, Key: {item.Value[1]}");
            }
        }
    }
}
