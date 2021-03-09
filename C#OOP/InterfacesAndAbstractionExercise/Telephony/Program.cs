using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            ISmartphonable smartphone = new Smartphone();
            IStationaryPhonable stacionary = new Stacionary();

            string inputNumbers = Console.ReadLine(); 
           
            string pattern = @"(\b\d{10}\b)|(\b\d{7}\b)";
            Regex phoneNumbers = new Regex(pattern);         
            var validNumbers = phoneNumbers.Matches(inputNumbers);

            string inputSites = Console.ReadLine();
            
            string patternSites = @"(\b[a-zA-Z]+:\/\/[a-zA-Z]+\.[a-zA-Z]+\.[a-zA-Z]+\b)|(\b[a-zA-Z]+\.[a-zA-Z]+\.[a-zA-Z]+\b)|(\b[a-zA-Z]+:\/\/[a-zA-Z]+\.[a-zA-Z]+\b)|(\b[a-zA-Z]+\.[a-zA-Z]+\b)";
            Regex sites = new Regex(patternSites);
            var validSites = sites.Matches(inputSites);
            
            foreach (Match item in validNumbers)
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

            foreach (Match item in validSites)
            {
                smartphone.Browsing(item.ToString());
            }
        }
    }
}
