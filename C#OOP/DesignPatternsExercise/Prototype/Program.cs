using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Sandwich sandwich = new Sandwich("grain", "rockfor", "chicken", "onion, spinach");
            Sandwich prototypeSandwich = (Sandwich)sandwich.Clone();

            Console.WriteLine(prototypeSandwich.GetIngredients());

            SandwichMenu sandwiches = new SandwichMenu();

            sandwiches["Chicken"] = new Sandwich("grain", "rockfor", "chicken", "onion");
            sandwiches["Beef"] = new Sandwich("grain", "mature", "beef", "onion");
            sandwiches["Veggie"] = new Sandwich("grain", "", "", "onion, spinach");

            sandwiches["LoadedChicken"] = new Sandwich("rye", "gauda, mature", "chicken", "onion");
            sandwiches["ThreeMeat"] = new Sandwich("wheat", "swiss", "beef, bacon, ham", "tomato");

            Sandwich sandwich1 = sandwiches["Beef"].Clone() as Sandwich;
            Sandwich sandwich2 = sandwiches["Veggie"].Clone() as Sandwich;
            Sandwich sandwich3 = sandwiches["ThreeMeat"].Clone() as Sandwich;

            Console.WriteLine(sandwich3.GetIngredients());

        }
    }
}
