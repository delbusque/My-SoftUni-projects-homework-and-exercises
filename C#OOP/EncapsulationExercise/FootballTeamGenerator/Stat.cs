using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public abstract class Stat
    {
        private double level;

        public Stat(double level)
        {
            Level = level;
        }
        
        
        public double Level
        {
            get => level; set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"{GetType().Name} should be between 0 and 100.");
                }
                else
                {
                    level = value;
                }
            }

        }
    }
}
