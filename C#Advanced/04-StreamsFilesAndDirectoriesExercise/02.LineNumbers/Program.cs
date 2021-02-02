using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine("data", "text.txt");
            var line = File.ReadAllLines(path);
            
            for (int i = 0; i < line.Length; i++)
            {
                string current = line[i];
                int countLetters = 0;
                int countMarks = 0;

                for (int j = 0; j < current.Length; j++)
                {
                    if (Char.IsLetter(current[j]))
                    {
                        countLetters++;
                    }
                    else if(Char.IsPunctuation(current[j]))
                    {
                        countMarks++;
                    }
                } 

                line[i] = $"Line {i + 1}: {line[i]} ({countLetters})({countMarks})";
            }

            File.WriteAllLines("output.txt", line);
        }
    }
}
