using System;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string longestWord = input[0];
            string shortestWord = input[1];
            string temp = string.Empty;

            if (longestWord.Length < shortestWord.Length)
            {
                temp = longestWord;
                longestWord = shortestWord;
                shortestWord = temp;
            }
      
            int sum = CharMultiplier(longestWord, shortestWord);
            Console.WriteLine(sum);

        }

        public static int CharMultiplier(string longest, string shortest)
        {
            int sum = 0;

            for (int i = 0; i < shortest.Length; i++)
            {
                sum += longest[i] * shortest[i];
            }

            for (int i = shortest.Length; i < longest.Length; i++)
            {
                sum += longest[i];
            }

            return sum;
        }
    }
}
