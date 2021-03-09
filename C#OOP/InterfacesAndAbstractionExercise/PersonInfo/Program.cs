using System;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string birthdate = Console.ReadLine();


            IBirthable person = new Citizen(name, age, id, birthdate);
            IIdentifiable citizen = new Citizen(name, age, id, birthdate);
            
            Console.WriteLine(citizen.Id);           
            Console.WriteLine(person.Birthdate);
        }
    }
}
