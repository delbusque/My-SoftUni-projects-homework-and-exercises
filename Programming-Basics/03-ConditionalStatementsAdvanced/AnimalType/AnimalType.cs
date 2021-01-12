using System;

namespace AnimalType
{
    class AnimalType
    {
        static void Main()
        {
            string name = Console.ReadLine();
            string type = "";

            switch (name)
            {
                case "dog":
                    type = "mammal"; break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    type = "reptile"; break;

                default:
                    type = "unknown"; break;                 
            }

            Console.WriteLine(type);
        }
    }
}
