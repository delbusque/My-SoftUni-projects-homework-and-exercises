using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _03.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var pattern = @"\b(?<day>(?:0[1-9])|(?:[1-2][0-9])|(?:3[01]))([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            Regex dates = new Regex(pattern);

            var validDates = dates.Matches(input);

            foreach (Match item in validDates)
            {
                var day = item.Groups["day"].Value;
                var month = item.Groups["month"].Value;
                var year = item.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
