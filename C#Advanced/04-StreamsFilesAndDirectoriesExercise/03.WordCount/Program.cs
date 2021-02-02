using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine("data", "words.txt");
            var pathText = Path.Combine("data", "text.txt");

            string[] words = File.ReadAllLines(path);

            string[] pattern = new string[] { " ", ".", ",", "-", "!", "?", Environment.NewLine };
            string text = File.ReadAllText(pathText).ToLower();
            string[] textArr = text.Split(pattern, StringSplitOptions.RemoveEmptyEntries);

            List<string> result = new List<string>();
            
            foreach (var word in words)
            {
                int counter = 0;
                
                foreach (var item in textArr)
                {
                    if (word == item)
                    {
                        counter++;
                    }
                }

                string current = $"{word} - {counter}";
                result.Add(current);
            }

            File.WriteAllLines("output.txt", result);

        }
    }
}
