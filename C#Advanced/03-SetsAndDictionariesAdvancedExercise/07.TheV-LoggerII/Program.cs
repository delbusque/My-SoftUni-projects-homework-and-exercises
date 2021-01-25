using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheV_LoggerII
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, SortedSet<string>>> vLogger
                = new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            string[] input = Console.ReadLine().Split();

            while (input[0] != "Statistics")
            {
                string followers = "followers";
                string following = "following";

                switch (input[1])
                {
                    case "joined":
                        string user = input[0];

                        if (!vLogger.ContainsKey(user))
                        {
                            vLogger.Add(user, new Dictionary<string, SortedSet<string>>());
                            vLogger[user].Add(followers, new SortedSet<string>());
                            vLogger[user].Add(following, new SortedSet<string>());

                        }
                        break;

                    case "followed":
                        string follower = input[0];
                        string vUser = input[2];  

                        if (vLogger.ContainsKey(follower) && vLogger.ContainsKey(vUser) && follower != vUser)
                        {
                            vLogger[vUser][followers].Add(follower);
                            vLogger[follower][following].Add(vUser);
                        }
                        break;
                }

                input = Console.ReadLine().Split();
            }

            Console.WriteLine($"The V-Logger has a total of {vLogger.Count} vloggers in its logs.");

            int counter = 1;
            
            foreach (var user in vLogger.OrderByDescending(x => x.Value["followers"].Count).ThenBy(x=>x.Value["following"].Count))
            {
                Console.WriteLine($"{counter}. {user.Key} : {user.Value["followers"].Count} followers, {user.Value["following"].Count} following");

                if (counter == 1)
                {
                    foreach (var item in user.Value["followers"])
                    {
                        Console.WriteLine($"*  {item}");
                    }
                }

                counter++;
            }
        }
    }
}
