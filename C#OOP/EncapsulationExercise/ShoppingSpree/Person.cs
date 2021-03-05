using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {       
        private string name;
        private decimal money;

        public Person(string name, decimal money)
        {
            Products = new List<Product>();
            Name = name;
            Money = money;
        }

        public List<Product> Products { get ; set; }
        public string Name { get => name;
            private set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                name = value;
            }
        }
        public decimal Money { get => money;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                money = value;
            } 
           
        }

        public override string ToString()
        {
            if (Products.Count > 0)
            {
                return $"{Name} - {string.Join(", ", Products.Select(p => p.Name))}";
            }
            else
            {
                return $"{Name} - Nothing bought";
            }           
        }
    }
}
