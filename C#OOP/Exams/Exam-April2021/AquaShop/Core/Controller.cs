using AquaShop.Core.Contracts;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Repositories;
using AquaShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Core
{
    public class Controller : IController
    {
        private DecorationRepository decorationRepository;
        private ICollection<IAquarium> aquariums;

        public Controller()
        {
            decorationRepository = new DecorationRepository();
            aquariums = new List<IAquarium>();
        }

        public string AddAquarium(string aquariumType, string aquariumName)
        {
            IAquarium currentAquarium = null;

            if (aquariumType == "FreshwaterAquarium")
            {
                currentAquarium = new FreshwaterAquarium(aquariumName);
            }
            else if (aquariumType == "SaltwaterAquarium")
            {
                currentAquarium = new SaltwaterAquarium(aquariumName);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAquariumType);
            }

            aquariums.Add(currentAquarium);

            return string.Format(OutputMessages.SuccessfullyAdded, aquariumType);
        }

        public string AddDecoration(string decorationType)
        {
            IDecoration currentDecoration = null;

            if (decorationType == "Ornament")
            {
                currentDecoration = new Ornament();
            }
            else if (decorationType == "Plant")
            {
                currentDecoration = new Plant();
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidDecorationType);
            }

            decorationRepository.Add(currentDecoration);

            return string.Format(OutputMessages.SuccessfullyAdded, decorationType);

        }

        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            var aquarium = aquariums.FirstOrDefault(a => a.Name == aquariumName);

            IFish currentFish = null;

            if (fishType == "FreshwaterFish")
            {
                currentFish = new FreshwaterFish(fishName, fishSpecies, price);
            }
            else if (fishType == "SaltwaterFish")
            {
                currentFish = new SaltwaterFish(fishName, fishSpecies, price);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidFishType);
            }

            if (aquarium == null)
            {
                return OutputMessages.UnsuitableWater;
            }

            else
            {
                aquarium.AddFish(currentFish);
                return String.Format(OutputMessages.EntityAddedToAquarium, fishType, fishName);
            }
          
        }

        public string CalculateValue(string aquariumName)
        {
            IAquarium aquarium = aquariums.FirstOrDefault(a => a.Name == aquariumName);

            decimal fishPrice = aquarium.Fish.Sum(f => f.Price);
            decimal decorationsPrice = aquarium.Decorations.Sum(d => d.Price);

            decimal totalValue = fishPrice + decorationsPrice;

            return string.Format(OutputMessages.AquariumValue, aquariumName, totalValue);

        }

        public string FeedFish(string aquariumName)
        {
            IAquarium aquarium = aquariums.FirstOrDefault(a => a.Name == aquariumName);

            foreach (var fish in aquarium.Fish)
            {
                fish.Eat();
            }

            return string.Format(OutputMessages.FishFed, aquarium.Fish.Count);
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            IAquarium aquarium = aquariums.FirstOrDefault(a => a.Name == aquariumName);
            IDecoration decoration = decorationRepository.Models.FirstOrDefault(d => d.GetType().Name
            == decorationType);

            if (decoration == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InexistentDecoration, decorationType));
            }

            aquarium.AddDecoration(decoration);
            decorationRepository.Remove(decoration);

            return string.Format(OutputMessages.EntityAddedToAquarium, decorationType, aquariumName);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var aquarium in aquariums)
            {
                sb.AppendLine(aquarium.GetInfo());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
