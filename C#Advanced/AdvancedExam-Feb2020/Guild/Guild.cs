using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        public List<Player> playerList;

        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            playerList = new List<Player>();
        }
        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count => playerList.Count;

        public void AddPlayer(Player player)
        {
            if (playerList.Count < Capacity)
            {
                playerList.Add(player);
            }
        }
        public bool RemovePlayer(string name)
        {                    
            Player forRemove = playerList.FirstOrDefault(f=>f.Name == name);

            if (forRemove == null)
            {
                return false;
            }
            else
            {
                playerList.Remove(forRemove);
                return true;
            }
        }

        public void PromotePlayer(string name)
        {
            for (int i = 0; i < playerList.Count; i++)
            {
                if (playerList[i].Name == name && playerList[i].Rank != "Member")
                {
                    playerList[i].Rank = "Member";
                    break;
                }
            }

        }

        public void DemotePlayer(string name)
        {
            for (int i = 0; i < playerList.Count; i++)
            {
                if (playerList[i].Name == name && playerList[i].Rank != "Trial")
                {
                    playerList[i].Rank = "Trial";
                    break;
                }
            }
        }

        public Player[] KickPlayersByClass(string clas)
        {
            List<Player> kicked = playerList.Where(p => p.Class == clas).ToList();

            playerList = playerList.Where(p => p.Class != clas).ToList();

            return kicked.ToArray();
        }

        public string Report()
        {
            StringBuilder guildSb = new StringBuilder();
            guildSb.AppendLine($"Players in the guild: {Name}");

            foreach (var player in playerList)
            {
                guildSb.AppendLine($"{player.ToString()}");
            }

            return guildSb.ToString();
        }
    }
}
