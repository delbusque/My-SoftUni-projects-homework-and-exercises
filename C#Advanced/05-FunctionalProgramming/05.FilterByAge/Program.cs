using System;
using System.Collections.Generic;

namespace _05.FilterByAge
{
    class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Person[] people = new Person[n];

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                people[i] = new Person();
                people[i].Name = input[0];
                people[i].Age = int.Parse(input[1]);
            }

            string filter = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Func<Person, string> formatter = GetFormatter(Console.ReadLine());

            Func<Person, bool> condition = GetAgeCondition(filter, age);

            PrintPeople(people, condition, formatter);

        }

        static Func<Person, string> GetFormatter(string format)
        {
            switch (format)
            {
                case "name": return p => $"{p.Name}";
                case "age": return p => $"{p.Age}";
                case "name age": return p => $"{p.Name} - {p.Age}";
                default:
                    return null;
            }
        }
        static Func<Person, bool> GetAgeCondition(string filter, int age)
        {
            switch (filter)
            {
                case "younger": return p => p.Age < age;
                case "older": return p => p.Age >= age;

                default:
                    return null;
                    break;
            }
        }
        static void PrintPeople(Person[] people, Func<Person, bool> condition, Func<Person, string> formatter)
        {
            foreach (var item in people)
            {
                if (condition(item))
                {
                    Console.WriteLine(formatter(item));
                }
            }
        }     
    }
}
