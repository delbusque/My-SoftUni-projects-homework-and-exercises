using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        protected Animal(string name, string favouritedFood)
        {
            Name = name;
            FavouritedFood = favouritedFood;
        }
        
        public string Name { get; protected set; }

        public string FavouritedFood { get; protected set; }

        public virtual string ExplainSelf()
        {
            return $"I am {Name} and my fovourite food is {FavouritedFood}";
        }
    }
}
