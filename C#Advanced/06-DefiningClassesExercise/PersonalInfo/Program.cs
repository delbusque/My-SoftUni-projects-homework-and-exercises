using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] inputPeople = Console.ReadLine().Split();
                Person currPerson = new Person(inputPeople[0], int.Parse(inputPeople[1]));
                people.Add(currPerson);
            }

            foreach (var person in people.OrderBy(p => p.Name))
            {
                if (person.Age > 30)
                {
                    Console.WriteLine($"{person.Name} - {person.Age}");
                }
 
            }
        }
    }
}
