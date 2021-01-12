using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> synomymDictionary = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();

                if (!synomymDictionary.ContainsKey(word))
                {
                    synomymDictionary.Add(word, new List<string>());
                    synomymDictionary[word].Add(synonim);

                }
                else
                {
                    synomymDictionary[word].Add(synonim);
                }
            }

            foreach (var item in synomymDictionary)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
