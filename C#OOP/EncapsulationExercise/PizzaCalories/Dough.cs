using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string bakingTehnique;
        private double weight;

        public Dough(string flourType, string bakingTehnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTehnique = bakingTehnique;
            this.Weight = weight;
            Calories = GetDoughCalories(flourType, bakingTehnique);
        }

        public string FlourType { get => flourType;
            private set
            {
                if (value.ToLower() == "white" || value.ToLower() == "wholegrain")
                {
                    flourType = value;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
            }
        }

        public string BakingTehnique { get => bakingTehnique;
            private set
            {
                switch (value.ToLower())
                {
                    case "crispy":
                    case "chewy":
                    case "homemade":
                        bakingTehnique = value;
                        break;
                    
                    default:
                        throw new ArgumentException("Invalid type of dough.");
                }
            }
        }

        public double Weight { get => weight;
            private set
            {
                if (value > 0 && value <= 200)
                {
                    weight = value;
                }
                else
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
            }
        }


        public double Calories { get; private set; }

        private double GetDoughCalories(string flourType, string bakingTehnique)
        {
            double flourModifier = 0;
            double bakingModifier = 0;
            double doughCaloresPerGram = 0;

            switch (flourType.ToLower())
            {
                case "white":
                    flourModifier = 1.5;
                    break;
                case "wholegrain":
                    flourModifier = 1;
                    break;
            }

            switch (bakingTehnique.ToLower())
            {
                case "crispy":
                    bakingModifier = 0.9;
                    break;
                case "chewy":
                    bakingModifier = 1.1;
                    break;
                case "homemade":
                    bakingModifier = 1;
                    break;
            }

            doughCaloresPerGram += 2 * weight * flourModifier * bakingModifier;

            return doughCaloresPerGram;
        }
    }
}
