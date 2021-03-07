using System;

namespace PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pizzaInput = Console.ReadLine().Split();
            string pizzaName = pizzaInput[1];
            
            string[] input = Console.ReadLine().Split();
            string flourType = input[1];
            string bakingTehnique = input[2];
            double weight = double.Parse(input[3]);

            string[] inputTopping = Console.ReadLine().Split();

            try
            {
                Dough dough = new Dough(flourType, bakingTehnique, weight);
                Pizza pizza = new Pizza(pizzaName, dough);

                while (inputTopping[0] != "END")
                {
                    string toppingKind = inputTopping[1];
                    double toppingWeight = double.Parse(inputTopping[2]);

                    Topping topp = new Topping(toppingKind, toppingWeight);
                    pizza.AddTopping(topp);

                    inputTopping = Console.ReadLine().Split();

                }
                Console.WriteLine($"{pizza.Name} - {pizza.Calories:f2} Calories.");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }   
        }
    }
}
