using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();

            keyMaterials.Add("shards", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);

            bool isObtained = false;

            while (true)
            {
                int quantity = 0;
                string material = string.Empty;
                
                for (int i = 0; i < input.Length-1; i = i + 2)
                {
                    quantity = int.Parse(input[i]);
                    material = input[i + 1].ToLower();

                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        keyMaterials[material] += quantity;

                        if (keyMaterials[material] >= 250)
                        {
                            keyMaterials[material] -= 250;

                            if (material == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");                             
                            }
                            else if (material == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                            }
                            else if (material == "motes")
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }

                            isObtained = true;
                            break;
                        }
                    }

                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials.Add(material, 0);
                        }

                        junkMaterials[material] += quantity;
                    }
                }

                if (isObtained)
                {
                    break;
                }

                input = Console.ReadLine().Split();
            }

            Dictionary<string, int> orderedKeyMaterials = keyMaterials.OrderByDescending(x => x.Value)
                                                          .ThenBy(x => x.Key)
                                                          .ToDictionary(k => k.Key, k => k.Value);

            foreach (var item in orderedKeyMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junkMaterials.OrderBy(i=>i.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
