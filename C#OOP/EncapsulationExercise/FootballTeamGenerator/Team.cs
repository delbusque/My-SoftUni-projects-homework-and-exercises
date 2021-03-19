using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Team
    {        
        public Team(string name)
        {
            Name = name;
            players = new List<Player>();
        }

        public List<Player> players { get ; set; }
        public string Name { get; set; }

        public double Rating { get; set; }

        public void AddPlayer(Player player)
        {          
            players.Add(player);
            double ratings = 0;

            foreach (var item in players)
            {
                ratings += item.SkillLevel;
            }

            ratings /= players.Count;
            Rating = Math.Round(ratings);
        }

        public void RemovePlayer(Player player)
        {
            players.Remove(player);
            double ratings = 0;

            foreach (var item in players)
            {
                ratings += item.SkillLevel;
            }

            ratings /= players.Count;
            Rating = Math.Round(ratings);
        }
    }
}
