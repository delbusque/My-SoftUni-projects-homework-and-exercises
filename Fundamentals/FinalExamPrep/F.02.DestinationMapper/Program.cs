using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace F._02.DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"([=/])(?<place>[A-Z][A-Za-z]{2,})\1";
            Regex placeRegex = new Regex(pattern);

            MatchCollection places = placeRegex.Matches(input);

            int travelPoints = 0;
            List<string> stringedPlaced = new List<string>();

            foreach (Match item in places)
            {
                travelPoints += item.Groups["place"].Value.Length;
                stringedPlaced.Add(item.Groups["place"].Value);
            }

            if (stringedPlaced.Count > 0)
            {
                Console.WriteLine($"Destinations: {string.Join(", ", stringedPlaced)}");
                Console.WriteLine($"Travel Points: {travelPoints}");
            }

            else
            {
                Console.WriteLine($"Destinations:");
                Console.WriteLine($"Travel Points: {travelPoints}");
            }
            
            
        }
    }
}
