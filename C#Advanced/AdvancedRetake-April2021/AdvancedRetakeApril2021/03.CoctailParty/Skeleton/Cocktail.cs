using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocktailParty
{
    public class Cocktail
    {
        private List<Ingredient> ingredients;

        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            Name = name;
            Capacity = capacity;
            MaxAlcoholLevel = maxAlcoholLevel;
            ingredients = new List<Ingredient>();
        }

        //public List<Ingredient> Ingredients { get; set; }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int MaxAlcoholLevel { get; set; }

        public int CurrentAlcoholLevel { 
            
            get
            {
                int alcoholLevel = 0;

                foreach (var item in ingredients)
                {
                    alcoholLevel += item.Alcohol;
                }

                return alcoholLevel;
            }
        }

        public void Add(Ingredient ingredient)
        {
            if (!ingredients.Contains(ingredient))
            {
                
                if (CurrentAlcoholLevel <= MaxAlcoholLevel && ingredient.Quantity <= Capacity)
                {
                    ingredients.Add(ingredient);
                }
            }
        }

        public bool Remove(string name)
        {
            Ingredient toRemove = ingredients.FirstOrDefault(i => i.Name == name);

            return ingredients.Remove(toRemove);
        }

        public Ingredient FindIngredient(string name)
        {
            Ingredient toReturn = ingredients.FirstOrDefault(i => i.Name == name);

            return toReturn;
        }

        public Ingredient GetMostAlcoholicIngredient()
        {
            foreach (var item in ingredients.OrderByDescending(i => i.Alcohol))
            {
                return item;
            }

            return null;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cocktail: {Name} - Current Alcohol Level: {CurrentAlcoholLevel}");

            foreach (var item in ingredients)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
