using System;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {           
           
            string pattern = @"\B(\+359)([\s\-])2\2([0-9]{3})\2([0-9]{4})\b";
           
            Regex sofiaPhones = new Regex(pattern);

            string inputNumbers = Console.ReadLine();

            var validNumbers = sofiaPhones.Matches(inputNumbers);

            Console.WriteLine(string.Join(", ", validNumbers));

        }
    }
}
