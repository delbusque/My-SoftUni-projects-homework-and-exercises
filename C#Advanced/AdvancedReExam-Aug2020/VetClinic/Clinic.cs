using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        List<Pet> pets;

        public Clinic(int capacity)
        {
            Capacity = capacity;
            pets = new List<Pet>();
        }
        public int Capacity { get; set; }

        public int Count => pets.Count;

        public void Add(Pet pet)
        {
            if (pets.Count < Capacity)
            {
                pets.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            Pet toRemove = pets.FirstOrDefault(n => n.Name == name);

            if (toRemove == null)
            {
                return false;
            }
            else
            {
                pets.Remove(toRemove);
                return true;
            }
        }

        public Pet GetPet(string name, string owner)
        {
            return pets.FirstOrDefault(n => n.Name == name && n.Owner == owner);
        }

        public Pet GetOldestPet()
        {
            Pet oldest = null;
            int age = int.MinValue;

            foreach (var pet in pets)
            {
                if (pet.Age > age)
                {
                    oldest = pet;
                    age = pet.Age;
                }
            }

            return oldest;
        }

        public string GetStatistics()
        {
            StringBuilder statistics = new StringBuilder();

            statistics.AppendLine("The clinic has the following patients:");

            foreach (var pet in pets)
            {
                statistics.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }

            return statistics.ToString();
        }


    }
}
