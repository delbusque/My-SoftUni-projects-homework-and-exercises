using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        List<Racer> racers;

        public Race(string name, int capaity)
        {
            Name = name;
            Capacity = capaity;
            racers = new List<Racer>();
        }
        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count => racers.Count;

        public void Add(Racer racer)
        {
            if (racers.Count < Capacity)
            {
                racers.Add(racer);
            }
        }

        public bool Remove(string name)
        {
            Racer toRemove = racers.FirstOrDefault(n => n.Name == name);

            if (toRemove == null)
            {
                return false;
            }
            else
            {
                racers.Remove(toRemove);
                return true;
            }
        }

        public Racer GetOldestRacer()
        {
            Racer oldest = null;
            int age = int.MinValue;

            foreach (var racer in racers)
            {
                if (racer.Age > age)
                {
                    oldest = racer;
                    age = racer.Age;
                }
            }

            return oldest;
        }

        public Racer GetRacer(string name)
        {
            return racers.FirstOrDefault(n => n.Name == name);
        }

        public Racer GetFastestRacer()
        {
            List<Racer> bySpeed = racers.OrderByDescending(r => r.Car.Speed).ToList();           
            return bySpeed[0];
        }

        public string Report()
        {
            StringBuilder report = new StringBuilder();
            report.AppendLine($"Racers participating at {Name}:");

            foreach (var racer in racers)
            {
                report.AppendLine(racer.ToString());
            }

            return report.ToString().TrimEnd();

        }

    }
}
