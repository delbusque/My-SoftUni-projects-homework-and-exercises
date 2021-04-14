using Bakery.Models.Drinks.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery.Models.Drinks
{
    public abstract class Drink : IDrink
    {
        private string name;
        private decimal price;
        private int portion;
        private string brand;


        public Drink(string name, int portion, decimal price, string brand)
        {
            Name = name;
            Brand = brand;
            Portion = portion;
            Price = price;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or white space!");
                }
                name = value;
            }
        }

        public int Portion
        {
            get => portion;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Portion cannot be less or equal to zero");
                }
                portion = value;
            }
        }
        public decimal Price
        {
            get => price;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price cannot be less or equal to zero");
                }
                price = value;
            }
        }

        public string Brand
        {
            get => brand;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Brand cannot be null or white space!");
                }
                brand = value;
            }
        }

        public override string ToString()
        {
            return $"{Name} {Brand} - {Portion}ml - {Price:f2}lv";
        }
    }
}
