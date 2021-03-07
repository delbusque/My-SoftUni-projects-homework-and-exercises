using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private List<Topping> toppings;
        private string name;
        private int toppingCount;

        public Pizza(string name, Dough dough)
        {
            Name = name;
            toppings = new List<Topping>();
            Dough = dough;
            Calories = dough.Calories;
            ToppingCount = 0;
        }

        public int ToppingCount { get => toppingCount; private set
            {
                if (value >= 0 && value <= 10)
                {
                    toppingCount = value;
                }
                else
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }
            }
        }

        public double Calories { get; private set; }

        public string Name { get => name; private set
            {
                if (value.Length > 0 && value.Length <= 15)
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
            }
        }

        public Dough Dough { get; set; }

        public void AddTopping(Topping topping)
        {                       
            toppings.Add(topping);
            Calories += topping.Calories;
            ToppingCount++;
        }
    }
}
