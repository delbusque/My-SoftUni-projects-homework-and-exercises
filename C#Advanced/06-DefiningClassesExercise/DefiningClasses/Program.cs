using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> members = new List<Person>();
            Family family = new Family(members);

            for (int i = 0; i < n; i++)
            {
                string[] familyInput = Console.ReadLine().Split();

                string name = familyInput[0];
                int age = int.Parse(familyInput[1]);
                Person currPerson = new Person(name, age);
                family.AddMember(currPerson);
            }

            Person oldestMember = family.GetOldestMember(members);
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
