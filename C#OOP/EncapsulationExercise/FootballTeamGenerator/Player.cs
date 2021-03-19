using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private double skillLevel;
        public Player(string playerName, Endurance endurance, Sprint sprint, Dribble dribble, Passing passing, Shooting shooting)
        {
            Name = playerName;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;

            skillLevel = (Endurance.Level + Sprint.Level + Dribble.Level + Passing.Level + Shooting.Level) / 5;

            SkillLevel = skillLevel;

        }

        public double SkillLevel { get; }
        
        public string Name { get => name; set
            {
                if (value == string.Empty || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                name = value;
            }
        }

        public Endurance Endurance { get; set; }

        public Sprint Sprint { get; set; }

        public Dribble Dribble { get; set; }

        public Passing Passing { get; set; }

        public Shooting Shooting { get; set; }
    }
}
