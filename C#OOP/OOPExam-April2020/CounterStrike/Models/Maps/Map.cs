using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players;
using CounterStrike.Models.Players.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CounterStrike.Models.Maps
{
    public class Map : IMap
    {
        private List<IPlayer> terrorists;
        private List<IPlayer> counterTerrorists;

        public Map()
        {
            terrorists = new List<IPlayer>();
            counterTerrorists = new List<IPlayer>();
        }


        public string Start(ICollection<IPlayer> players)
        {
            SeparateTeams(players);

            while (IsTeamAlive(terrorists) && IsTeamAlive(counterTerrorists))
            {
                AttackTeam(terrorists, counterTerrorists);
                AttackTeam(counterTerrorists, terrorists);
            }

            if (IsTeamAlive(counterTerrorists))
            {
                return "Counter Terrorist wins!";
            }
            else if (IsTeamAlive(terrorists))
            {
                return "Terrorist wins!";
            }

            return "Something bad happened";
        }

        private bool IsTeamAlive(List<IPlayer> players)
        {
            return players.Any(p => p.IsAlive);
        }

        private void AttackTeam(List<IPlayer> attackingTeam, List<IPlayer> defendingTeam)
        {
            foreach (var attacker in attackingTeam)
            {
                foreach (var defender in defendingTeam)
                {
                    if (defender.IsAlive)
                    {
                        defender.TakeDamage(attacker.Gun.Fire());
                    }
                }
            }
        }

        private void SeparateTeams(ICollection<IPlayer> players)
        {
            foreach (var player in players)
            {
                if (player is CounterTerrorist)
                {
                    counterTerrorists.Add(player);
                }
                else if (player is Terrorist)
                {
                    terrorists.Add(player);
                }
            }
        }
    }
}
