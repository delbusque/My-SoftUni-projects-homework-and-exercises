using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(" -> ");
                string colour = tokens[0];
                string[] clothes = tokens[1].Split(',');

                if (!wardrobe.ContainsKey(colour))
                {
                    wardrobe.Add(colour, new Dictionary<string, int>());

                    for (int j = 0; j < clothes.Length; j++)
                    {
                        if (!wardrobe[colour].ContainsKey(clothes[j]))
                        {
                            wardrobe[colour].Add(clothes[j], 1);
                        }
                        else
                        {
                            wardrobe[colour][clothes[j]]++;
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < clothes.Length; j++)
                    {
                        if (!wardrobe[colour].ContainsKey(clothes[j]))
                        {
                            wardrobe[colour].Add(clothes[j], 1);
                        }
                        else
                        {
                            wardrobe[colour][clothes[j]]++;
                        }
                    }
                }
            }

            string[] cmds = Console.ReadLine().Split();
            string lookForColour = cmds[0];
            string lookForCloth = cmds[1];

            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");

                foreach (var color in item.Value)
                {
                    if (item.Key == lookForColour && color.Key == lookForCloth)
                    {
                        Console.WriteLine($"* {color.Key} - {color.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {color.Key} - {color.Value}");
                    }
                }
            }
        }
    }
}
