﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Animal
    {
        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
        public string Name { get; set; }

        public double Weight { get; set; }

        public int FoodEaten { get; set; }

        public abstract string AskForFood();

        public abstract void Eat(string foodType, int quantity);
    }
}
