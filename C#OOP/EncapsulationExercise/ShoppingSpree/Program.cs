using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] personsInput = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            List<Person> persons = new List<Person>();

            string[] productsInput = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            List<Product> products = new List<Product>();

            try
            {
                
                foreach (var item in personsInput)
                {
                    string[] temp = item.Split("=");
                    Person person = new Person(temp[0], decimal.Parse(temp[1]));
                    persons.Add(person);
                }
               
                foreach (var item in productsInput)
                {
                    string[] temp = item.Split("=");
                    Product product = new Product(temp[0], decimal.Parse(temp[1]));
                    products.Add(product);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "END")
            {
                string name = command[0];
                string product = command[1];

                foreach (var person in persons)
                {
                    if (name == person.Name)
                    {
                        foreach (var item in products)
                        {
                            if (product == item.Name)
                            {
                                if (person.Money >= item.Cost)
                                {
                                    person.Products.Add(item);
                                    person.Money -= item.Cost;
                                    Console.WriteLine($"{person.Name} bought {item.Name}");
                                }
                                else
                                {
                                    Console.WriteLine($"{person.Name} can't afford {item.Name}");
                                }
                            }
                        }
                    }
                }
                
                command = Console.ReadLine().Split();
            }

            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
        }
    }
}
