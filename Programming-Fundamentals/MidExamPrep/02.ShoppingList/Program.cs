using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine().Split('!').ToList();

            bool notShopping = true;
      
            while (notShopping)
            {
                string input = Console.ReadLine();

                if (input == "Go Shopping!")
                {
                    notShopping = false;
                    continue;
                }

                string[] cmdArgs = input.Split().ToArray();
                string item = cmdArgs[1];

                if (cmdArgs[0] == "Urgent")
                {
                    if (shoppingList.Contains(item))
                    {
                        continue;
                    }
                    shoppingList.Insert(0, item);
                }

                else if (cmdArgs[0] == "Unnecessary")
                {
                    if (shoppingList.Contains(item))
                    {
                        shoppingList.Remove(item);
                    }
                    continue;
                }

                else if (cmdArgs[0] == "Correct")
                {
                    if (shoppingList.Contains(item))
                    {
                        string newItem = cmdArgs[2];
                        shoppingList[shoppingList.FindIndex(ind => ind.Equals(item))] = newItem;
                    }
                    continue;
                        
                }
                else if (cmdArgs[0] == "Rearrange")
                {
                    if (shoppingList.Contains(item))
                    {
                        shoppingList.Remove(item);
                        shoppingList.Add(item);
                    }
                    continue;
                }
            }

            Console.WriteLine(string.Join(", ", shoppingList));
           
        }
    }
}
