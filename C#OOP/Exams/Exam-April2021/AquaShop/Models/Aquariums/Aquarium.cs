using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Models.Aquariums
{
    public abstract class Aquarium : IAquarium
    {
        private string name;
        private List<IDecoration> decorations;
        private List<IFish> fishList;

        protected Aquarium(string name, int capacity)
        {
            decorations = new List<IDecoration>();
            fishList = new List<IFish>();

            Name = name;
            Capacity = capacity;
        }
        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidAquariumName);
                }

                name = value;
            }
        }


        public int Capacity { get; private set; }

        public int Comfort => decorations.Sum(s => s.Comfort);

        public ICollection<IDecoration> Decorations => decorations.AsReadOnly();

        public ICollection<IFish> Fish => fishList.AsReadOnly();

        public void AddDecoration(IDecoration decoration)
        {
            decorations.Add(decoration);
        }

        public void AddFish(IFish fish)
        {
            if (Capacity <= 0)
            {
                throw new InvalidOperationException(ExceptionMessages.NotEnoughCapacity);
            }

            fishList.Add(fish);
            Capacity--;
        }

        public void Feed()
        {
            foreach (var fish in fishList)
            {
                fish.Eat();
            }
        }

        public string GetInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Name} ({GetType().Name}):");

            if (fishList == null)
            {
                sb.AppendLine("none");
            }
            else
            {
                sb.AppendLine($"Fish: {string.Join(", ", fishList.Select(f => f.Name))}");
            }

            sb.AppendLine($"Decorations: {decorations.Count}");
            sb.AppendLine($"Comfort: {Comfort}");

            return sb.ToString().TrimEnd();
        }

        public bool RemoveFish(IFish fish)
        {
                return fishList.Remove(fish);
        }
    }
}
