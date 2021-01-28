using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            string[] contestsInput = Console.ReadLine().Split(":");

            while (contestsInput[0] != "end of contests")
            {
                contests.Add(contestsInput[0], contestsInput[1]);

                contestsInput = Console.ReadLine().Split(":");
            }

            SortedDictionary<string, Dictionary<string, int>> candidates = new SortedDictionary<string, Dictionary<string, int>>();
            string[] candData = Console.ReadLine().Split("=>");

            while (candData[0] != "end of submissions")
            {
                string contest = candData[0];
                string password = candData[1];
                string username = candData[2];
                int points = int.Parse(candData[3]);

                if (contests.ContainsKey(contest) && contests[contest] == password)
                {
                    if (!candidates.ContainsKey(username))
                    {
                        candidates.Add(username, new Dictionary<string, int>());
                        candidates[username].Add(contest, points);

                    }
                    else
                    {
                        if (!candidates[username].ContainsKey(contest))
                        {
                            candidates[username].Add(contest, points);
                        }
                        else
                        {
                            if (candidates[username][contest] < points)
                            {
                                candidates[username][contest] = points;
                            }
                        }
                    }
                }

                candData = Console.ReadLine().Split("=>");
            }



            Dictionary<string, int> overal = new Dictionary<string, int>(candidates.Count);

            foreach (var item in candidates)
            {
                overal.Add(item.Key, 0);

                foreach (var cont in item.Value.OrderByDescending(x => x.Value))
                {
                    overal[item.Key] += cont.Value;
                }
            }

            foreach (var item in overal.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"Best candidate is {item.Key} with total {item.Value} points.");
                break;
            }
            Console.WriteLine("Ranking:");

            foreach (var item in candidates)
            {
                Console.WriteLine(item.Key);
                
                foreach (var cont in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {cont.Key} -> {cont.Value}");                   
                }
            }
        }
    }
}
