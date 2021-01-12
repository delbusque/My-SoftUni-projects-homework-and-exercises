using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            // SoftUni -> AA12345

            string input = Console.ReadLine();

            Dictionary<string, List<string>> companiesList = new Dictionary<string, List<string>>();

            while (input != "End")
            {
                string[] currentArgm = input.Split(" -> ");
                string company = currentArgm[0];
                string id = currentArgm[1];

                if (!companiesList.ContainsKey(company))
                {
                    companiesList.Add(company, new List<string>());
                    companiesList[company].Add(id);
                }
                else
                {
                    if (!companiesList[company].Contains(id))
                    {
                        companiesList[company].Add(id);
                    }                
                }

                input = Console.ReadLine();
            }

            foreach (var item in companiesList.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);

                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.WriteLine($"-- {item.Value[i]}");
                }
            }
        }
    }
}
