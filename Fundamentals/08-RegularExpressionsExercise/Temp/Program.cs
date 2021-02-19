using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternDigits = @"[\WA-Za-z]";
            string patternLetters = @"[\W\d]";
            
            string[] playerLine = Console.ReadLine().Split(", ");

            SortedDictionary<string, int> players = new SortedDictionary<string, int>();

            foreach (var item in playerLine)
            {
                players.Add(item, 0);
            }

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string currentName = Regex.Replace(input, patternLetters, "");
                string currentDigits = Regex.Replace(input, patternDigits, "");
                int sum = 0;

                if (players.ContainsKey(currentName)) 
                {
                    foreach (var item in currentDigits)
                    {
                        int digit = int.Parse(item.ToString());
                        sum += digit;
                    }

                    players[currentName] += sum;
                }

                input = Console.ReadLine();
            }

            int count = 1;

            foreach (var item in players.OrderByDescending(x => x.Value))
            {
                string text = count == 1 ? "st" : count == 2 ? "nd" : "rd";
               
                Console.WriteLine($"{count++}{text} place: {item.Key}");

                if (count == 4)
                {
                    break;
                }
                
            }
        }
    }
}
