using System;
using System.Collections.Generic;

namespace BirthdayCelebrations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            List<IBirthable> birthable = new List<IBirthable>();

            while (input[0] != "End")
            {
                if (input[0] == "Citizen")
                {
                    string name = input[1];
                    int age = int.Parse(input[2]);
                    string id = input[3];
                    string birthdate = input[4];
                    IBirthable citizen = new Citizen(name, age, id, birthdate);
                    birthable.Add(citizen);
                }
                else if (input[0] == "Pet")
                {
                    string name = input[1];
                    string birthdate = input[2];
                    IBirthable pet = new Pet(name, birthdate);
                    birthable.Add(pet);
                }

                input = Console.ReadLine().Split();
            }

            string year = Console.ReadLine();

            foreach (var birthdatable in birthable)
            {
                string[] birthDate = birthdatable.Birthdate.Split('/');
                if (year == birthDate[2])
                {
                    Console.WriteLine(birthdatable.Birthdate);
                }
            }
        }
    }
}
