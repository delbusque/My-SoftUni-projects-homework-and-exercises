using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Cat : Animal
    {
        public Cat(string name, string favouritedFood) 
            : base(name, favouritedFood)
        {
        }
        public override string ExplainSelf()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"I am {Name} and my fovourite food is {FavouritedFood}");
            sb.Append("MEEOW");

            return sb.ToString();          
        }
    }
}
