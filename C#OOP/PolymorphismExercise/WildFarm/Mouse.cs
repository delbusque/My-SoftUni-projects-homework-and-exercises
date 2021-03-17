using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override string AskForFood()
        {
            return "Squeak";
        }

        public override void Eat(string foodType, int quantity)
        {
            if (foodType != nameof(Vegetable) && foodType != nameof(Fruit))
            {
                Console.WriteLine($"{GetType().Name} does not eat {foodType}!");
            }
            else
            {
                FoodEaten += quantity;
                Weight += quantity * 0.1;
            }
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
