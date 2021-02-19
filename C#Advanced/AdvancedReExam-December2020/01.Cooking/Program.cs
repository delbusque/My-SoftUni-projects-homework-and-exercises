using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> liquids = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> ingredients = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            SortedDictionary<string, int> cookedProducts = new SortedDictionary<string, int>();
            cookedProducts.Add("Bread", 0);
            cookedProducts.Add("Cake", 0);
            cookedProducts.Add("Fruit Pie", 0);
            cookedProducts.Add("Pastry", 0);

            while (liquids.Count != 0 && ingredients.Count != 0)
            {                
                if (liquids.Peek() + ingredients.Peek() == 25)
                {
                        liquids.Dequeue();
                        ingredients.Pop();
                        cookedProducts["Bread"] += 1;
                }
                else if (liquids.Peek() + ingredients.Peek() == 50)
                {
                        liquids.Dequeue();
                        ingredients.Pop();
                        cookedProducts["Cake"] += 1;
                }
                else if (liquids.Peek() + ingredients.Peek() == 75)
                {
                        liquids.Dequeue();
                        ingredients.Pop();
                        cookedProducts["Fruit Pie"] += 1;
                }
                else if (liquids.Peek() + ingredients.Peek() == 100)
                {
                        liquids.Dequeue();
                        ingredients.Pop();
                        cookedProducts["Pastry"] += 1;
                }
                else
                {
                    liquids.Dequeue();
                    int newIngredient = ingredients.Pop() + 3;
                    ingredients.Push(newIngredient);
                }
            }

            if (cookedProducts["Bread"] > 0 && cookedProducts["Cake"] > 0 &&
                cookedProducts["Fruit Pie"] > 0 && cookedProducts["Pastry"] > 0) 
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (liquids.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Liquids left: ");

                foreach (var item in liquids)
                {
                    sb.Append($"{item}, ");
                }

                string liquidStr = sb.ToString();
                char[] toTrim = new char[] { ',', ' ' };
                liquidStr = liquidStr.TrimEnd(toTrim);

                Console.WriteLine(liquidStr);
     
            }

            if (ingredients.Count == 0)
            {
                Console.WriteLine("Ingredients left: none");
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Ingredients left: ");

                foreach (var item in ingredients)
                {
                    sb.Append($"{item}, ");
                }

                string ingredientsStr = sb.ToString();
                char[] toTrim = new char[] { ',', ' ' };
                ingredientsStr = ingredientsStr.TrimEnd(toTrim);

                Console.WriteLine(ingredientsStr);

            }

            foreach (var item in cookedProducts)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
