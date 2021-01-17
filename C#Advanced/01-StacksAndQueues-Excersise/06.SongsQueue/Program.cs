using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songsLine = Console.ReadLine().Split(", ");
            Queue<string> songs = new Queue<string>(songsLine);

            string cmdArgs = Console.ReadLine();
            
            while (songs.Count > 0)
            {

                if (cmdArgs.Contains("Play"))
                {
                    songs.Dequeue();
                }

                else if (cmdArgs.Contains("Add"))
                {
                    string[] currentSong = cmdArgs.Split("Add ");

                    string songToAdd = string.Join("", currentSong);

                    if (songs.Contains(songToAdd))
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(songToAdd);
                    }
                }

                else if (cmdArgs.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ", songs));
                }

                cmdArgs = Console.ReadLine();
            }

            Console.WriteLine("No more songs!");
        }
    }
}
