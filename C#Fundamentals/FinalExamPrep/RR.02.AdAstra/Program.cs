using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RR._02.AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> matchedItems = new Dictionary<string, List<string>>();

            string pattern = @"([#|])(?<item>[a-zA-Z\s]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d*)\1";
            Regex list = new Regex(pattern);

            MatchCollection items = list.Matches(input);

            foreach (Match item in items)
            {
                string key = item.Groups["item"].Value; 
                
                if (!matchedItems.ContainsKey(key))
                {
                    matchedItems.Add(key, new List<string>());
                    matchedItems[key].Add(item.Groups["date"].Value);
                    matchedItems[key].Add(item.Groups["calories"].Value);
                }
                else
                {                    
                    matchedItems[key].Add(item.Groups["date"].Value);
                    matchedItems[key].Add(item.Groups["calories"].Value);
                }            
            }

            int totalCalories = 0;

            foreach (var item in matchedItems)
            {
                for (int i = 0; i < item.Value.Count; i+= 2)
                {
                    totalCalories += int.Parse(item.Value[i+1]);
                }
                                           
            }

            int days = totalCalories / 2000;

            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (var item in matchedItems)
            {
                for (int i = 0; i < item.Value.Count; i += 2)
                {
                    Console.WriteLine($"Item: {item.Key}, Best before: {item.Value[i]}, Nutrition: {item.Value[i+1]}");
                }           
            }  
        }
    }
}
