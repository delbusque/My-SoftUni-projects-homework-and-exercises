using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            ISmartphonable smartphone = new Smartphone();
            IStationaryPhonable stacionary = new Stacionary();

            string[] inputNumbers = Console.ReadLine().Split();

            string pattern = @"(\b\d{10}\b)|(\b\d{7}\b)";
            Regex phoneNumbers = new Regex(pattern);

            foreach (var item in inputNumbers)
            {
                if (phoneNumbers.IsMatch(item))
                {
                    if (item.Length == 7)
                    {
                        stacionary.Dialing(item.ToString());
                    }
                    else
                    {
                        smartphone.Calling(item.ToString());
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }

            string[] inputSites = Console.ReadLine().Split();

            string patternSites = @"(\b[a-zA-Z]+:\/\/[a-zA-Z]+\.[a-zA-Z]+\.[a-zA-Z]+\b)|(\b[a-zA-Z]+\.[a-zA-Z]+\.[a-zA-Z]+\b)|(\b[a-zA-Z]+:\/\/[a-zA-Z]+\.[a-zA-Z]+\b)|(\b[a-zA-Z]+\.[a-zA-Z]+\b)";
            Regex sites = new Regex(patternSites);

            foreach (var item in inputSites)
            {
                if (sites.IsMatch(item))
                {
                    smartphone.Browsing(item.ToString());
                }
                else
                {
                    Console.WriteLine("Invalid URL!");
                }
            } 
        }
    }
}
