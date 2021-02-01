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
            Dictionary<string, int> checkedWords = new Dictionary<string, int>();
            var pathWords = Path.Combine("data", "words.txt");
            var pathText = Path.Combine("data", "text.txt");
            List<string> words = new List<string>();

            using (StreamReader inputWords = new StreamReader(pathWords))
            {
                string[] input = inputWords.ReadToEnd().Split();
                for (int i = 0; i < input.Length; i++)
                {
                    words.Add(input[i].ToLower());
                }
            }

          
            using (StreamReader text = new StreamReader(pathText))
            {
                string[] pattern = { " ", "-", ".", ",", "!", "?", Environment.NewLine };
                string[] fullText = text.ReadToEnd().Split(pattern, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < fullText.Length; i++)
                {
                    foreach (var item in words)
                    {
                        if (item == fullText[i].ToLower())
                        {
                            if (!checkedWords.ContainsKey(item))
                            {
                                checkedWords.Add(item, 1);
                            }
                            else
                            {
                                checkedWords[item]++;
                            }
                        }
                    }
                    
                }
            }
            List<string> ready = new List<string>();
           
            
            foreach (var item in checkedWords.OrderByDescending(v=>v.Value))
            {
                ready.Add($"{item.Key} - {item.Value}");
            }
            using (StreamWriter output = new StreamWriter("output.txt"))
            {
                for (int i = 0; i < ready.Count; i++)
                {
                    output.WriteLine(ready[i]);
                }               
            }     
        }
    }
}
