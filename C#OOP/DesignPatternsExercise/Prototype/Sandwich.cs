using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Sandwich : SandwichPrototype
    {
        private string bread;
        private string cheese;
        private string meat;
        private string veggies;

        public Sandwich(string bread, string cheese, string meat, string veggies)
        {
            this.bread = bread;
            this.cheese = cheese;
            this.meat = meat;
            this.veggies = veggies;
        }

        public string GetIngredients()
        {
            return $"Sandwich with {bread} bread, {meat}, {cheese}, {veggies}";
        }

        public override SandwichPrototype Clone()
        {
            return MemberwiseClone() as SandwichPrototype;
        }
    }
}
