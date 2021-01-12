using System;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _02.EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string digitPattern = @"\d";
            string emojiPattern = @"(::[A-Z][a-z][a-z]+::)|(\*\*[A-Z][a-z][a-z]+\*\*)";
            Regex threshold = new Regex(digitPattern);
            Regex emoji = new Regex(emojiPattern);

            BigInteger coolThreshold = 1;

            string input = Console.ReadLine();

            var matchedDigits = threshold.Matches(input);
            int[] digits = new int[matchedDigits.Count];

            for (int i = 0; i < matchedDigits.Count; i++)
            {
                digits[i] = int.Parse(matchedDigits[i].ToString());
            }

            foreach (var item in digits)
            {
                coolThreshold *= item;
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");

            var matchedEmojis = emoji.Matches(input);

            Console.WriteLine($"{matchedEmojis.Count} emojis found in the text. The cool ones are:");

            Dictionary<string, BigInteger> emojiDict = new Dictionary<string, BigInteger>();

            string currentPattern = @"[A-Z][a-z][a-z]+";
            Regex currentThreshold = new Regex(currentPattern);

            foreach (var item in matchedEmojis)
            {
                var thresholdMatch = currentThreshold.Match(item.ToString());
                int currentSum = 0;

                string matchToString = thresholdMatch.ToString();
                emojiDict.Add(matchToString, 0);

                char[] currentEmoji = matchToString.ToCharArray();

                for (int i = 0; i < currentEmoji.Length; i++)
                {
                    currentSum += currentEmoji[i];
                }

                emojiDict[matchToString] = currentSum;

                if (emojiDict[matchToString] >= coolThreshold)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
