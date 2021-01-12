using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Text.RegularExpressions;

namespace R._02.MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"([@,#])(?<word1>[A-Za-z]{3,})\1\1(?<word2>[A-Za-z]{3,})\1";
            Regex mirror = new Regex(pattern);

            var mirrorWords = mirror.Matches(input);

            List<string> listMirrors = new List<string>();

            if (mirrorWords.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine($"{mirrorWords.Count} word pairs found!");

                foreach (Match item in mirrorWords)
                {
                    string wordOne = item.Groups["word1"].Value;
                    string wordTwo = item.Groups["word2"].Value;

                    string reversed = string.Concat(wordOne.Reverse());

                    if (reversed == wordTwo)
                    {
                        listMirrors.Add($"{wordOne} <=> {wordTwo}");
                    }
                }

                if (listMirrors.Count == 0)
                {
                    Console.WriteLine("No mirror words!");
                }
                else
                {
                    Console.WriteLine("The mirror words are:");
                    Console.WriteLine(string.Join(", ", listMirrors));
                }
            }
        }
    }
}
