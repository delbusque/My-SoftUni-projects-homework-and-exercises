using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private string toppingKind;
        private double weight;

        public Topping(string topping, double weight)
        {
            this.ToppingKind = topping;
            this.Weight = weight;
            Calories = GetToppingCalories(topping);
        }

        public string ToppingKind
        {
            get => toppingKind;
            private set
            {
                switch (value.ToLower())
                {
                    case "meat":
                    case "veggies":
                    case "cheese":
                    case "sauce":
                        toppingKind = value;
                        break;

                    default:
                        throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
            }
        }

        public double Weight
        {
            get => weight;
            private set
            {
                if (value > 0 && value <= 50)
                {
                    weight = value;
                }
                else
                {
                    throw new ArgumentException($"{toppingKind} weight should be in the range [1..50].");
                }
            }
        }

        public double Calories { get; private set; }

        private double GetToppingCalories(string topping)
        {
            double toppingModifier = 0;
            double toppingCalories = 0;

            switch (topping.ToLower())
            {
                case "meat":
                    toppingModifier = 1.2;
                    break;
                case "veggies":
                    toppingModifier = 0.8;
                    break;
                case "cheese":
                    toppingModifier = 1.1;
                    break;
                case "sauce":
                    toppingModifier = 0.9;
                    break;
            }

            toppingCalories += 2 * weight * toppingModifier;

            return toppingCalories;
        }
    }
}
