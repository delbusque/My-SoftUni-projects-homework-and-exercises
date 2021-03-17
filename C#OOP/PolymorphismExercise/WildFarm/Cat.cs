using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override string AskForFood()
        {
            return "Meow";
        }

        public override void Eat(string foodType, int quantity)
        {
            if (foodType != nameof(Vegetable) && foodType != nameof(Meat))
            {
                Console.WriteLine($"{GetType().Name} does not eat {foodType}!");
            }
            else
            {
                FoodEaten += quantity;
                Weight += quantity * 0.3;
            }
        }
    }
}
