using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string animalType = Console.ReadLine();
            List<Animal> animals = new List<Animal>();

            while (animalType != "Beast!")
            {
                string[] animalPropInput = Console.ReadLine().Split();

                if (animalPropInput.Length == 3)
                {
                    string name = animalPropInput[0];
                    int age = int.Parse(animalPropInput[1]);
                    string gender = animalPropInput[2].ToLower();

                    if (age <= 0)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        if (gender != "male" && gender != "female")
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        else
                        {
                            animals.Add(CreateAnimal(animalType, name, age, gender));
                        }
                    }
                }

                else
                {
                    string name = animalPropInput[0];
                    int age = int.Parse(animalPropInput[1]);
                    string gender = " ";

                    if (age <= 0)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        animals.Add(CreateAnimal(animalType, name, age, gender));
                    }
                }

                

                animalType = Console.ReadLine();
            }

            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }
        }

        public static Animal CreateAnimal(string animal, string name, int age, string gender)
        {
            Animal currentAnimal = null;
            
            switch (animal)
            {
                case "Dog":
                    currentAnimal = new Dog(name, age, gender);
                    break;

                case "Frog":
                    currentAnimal = new Frog(name, age, gender);
                    break;

                case "Cat":
                    currentAnimal = new Cat(name, age, gender);
                    break;

                case "Tomcat":
                    currentAnimal = new Tomcat(name, age);
                    break;

                case "Kitten":
                    currentAnimal = new Kitten(name, age);
                    break;
            }

            return currentAnimal;
        }
    }
}
