using System;
using System.Collections.Generic;

namespace WildFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            
            string[] animalInput = Console.ReadLine().Split();
            string[] foodInput = Console.ReadLine().Split();

            while (animalInput[0] != "End")
            {
                string type = animalInput[0];
                string name = animalInput[1];
                double weight = double.Parse(animalInput[2]);
                string foodType = foodInput[0];
                int quantity = int.Parse(foodInput[1]);

                if (type == nameof(Hen))
                {
                    double wingSize = double.Parse(animalInput[3]);

                    Bird hen = new Hen(name, weight, wingSize);
                    Console.WriteLine(hen.AskForFood());
                    hen.Eat(foodType, quantity);
                    animals.Add(hen);
                }
                else if (type == nameof(Owl))
                {
                    double wingSize = double.Parse(animalInput[3]);

                    Bird owl = new Owl(name, weight, wingSize);
                    Console.WriteLine(owl.AskForFood());
                    owl.Eat(foodType, quantity);
                    animals.Add(owl);
                }
                else if (type == nameof(Cat))
                {
                    string livingRegion = animalInput[3];
                    string breed = animalInput[4];

                    Feline cat = new Cat(name, weight, livingRegion, breed);
                    Console.WriteLine(cat.AskForFood());
                    cat.Eat(foodType, quantity);
                    animals.Add(cat);
                }
                else if (type == nameof(Tiger))
                {
                    string livingRegion = animalInput[3];
                    string breed = animalInput[4];

                    Feline tiger = new Tiger(name, weight, livingRegion, breed);
                    Console.WriteLine(tiger.AskForFood());
                    tiger.Eat(foodType, quantity);
                    animals.Add(tiger);
                }
                else if (type == nameof(Mouse))
                {
                    string livingRegion = animalInput[3];

                    Mammal mouse = new Mouse(name, weight, livingRegion);
                    Console.WriteLine(mouse.AskForFood());
                    mouse.Eat(foodType, quantity);
                    animals.Add(mouse);
                }
                else if (type == nameof(Dog))
                {
                    string livingRegion = animalInput[3];

                    Mammal dog = new Dog(name, weight, livingRegion);
                    Console.WriteLine(dog.AskForFood());
                    dog.Eat(foodType, quantity);
                    animals.Add(dog);
                }


                animalInput = Console.ReadLine().Split();
                if (animalInput[0] == "End")
                {
                    break;
                }
                foodInput = Console.ReadLine().Split();
            }

            foreach (var item in animals)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
