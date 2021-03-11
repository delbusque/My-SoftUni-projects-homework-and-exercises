using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Dog : Animal
    {
        public Dog(string name, string favouritedFood) 
            : base(name, favouritedFood)
        {
        }

        public override string ExplainSelf()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"I am {Name} and my fovourite food is {FavouritedFood}");
            sb.Append("DJAAF");

            return sb.ToString();
        }
    }
}
