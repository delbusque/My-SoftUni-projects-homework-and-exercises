using System;
using System.Text.RegularExpressions;

namespace _02.Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            string pattern = @"\|(?<name>[A-Z]{4,})\|:#(?<title>[a-zA-Z]+\s[a-zA-Z]+)#";
            Regex bosses = new Regex(pattern);

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                MatchCollection matchedBosses = bosses.Matches(input);

                if (matchedBosses.Count > 0)
                {
                    foreach (Match item in matchedBosses)
                    {
                        Console.WriteLine($"{item.Groups["name"]}, The {item.Groups["title"]}");
                        Console.WriteLine($">> Strength: {item.Groups["name"].Length}");
                        Console.WriteLine($">> Armour: {item.Groups["title"].Length}");
                    }
                }

                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}
