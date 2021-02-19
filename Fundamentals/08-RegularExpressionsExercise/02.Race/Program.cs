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
            string pattern = @"[A-Za-z\d]";
            Regex regex = new Regex(pattern);
            string[] playerLine = Console.ReadLine().Split(", ");

            SortedDictionary<string, int> players = new SortedDictionary<string, int>();

            foreach (var item in playerLine)
            {
                players.Add(item, 0);
            }

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                var currentMatch = regex.Matches(input);
                string[] elements = new string[currentMatch.Count];
                StringBuilder currentName = new StringBuilder();
                List<int> currentDigits = new List<int>();
              

                for (int i = 0; i < elements.Length; i++)
                {
                    elements[i] = currentMatch[i].ToString();

                    if (!(char.Parse(elements[i]) > 47 && char.Parse(elements[i]) < 58))
                    {
                        currentName.Append(elements[i]);
                    }
                    else
                    {
                        currentDigits.Add(int.Parse(elements[i]));
                    }
                }
                
                    if (players.ContainsKey(currentName.ToString()))
                    {
                        players[currentName.ToString()] += currentDigits.Sum();
                    }              

                input = Console.ReadLine();
            }

            int count = 1;

            foreach (var item in players.OrderByDescending(x=>x.Value))
            {
                string text = count == 1 ? "st" : count == 2 ? "nd" : "rd";
                
                if (count <= 3)
                {
                    Console.WriteLine($"{count++}{text} place: {item.Key}");
                }
            }
        }
    }
}
