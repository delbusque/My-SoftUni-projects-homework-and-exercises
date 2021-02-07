using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            Person pesho = new Person();
            pesho.Name = "Pesho";
            pesho.Age = 20;
            
            Person stamat = new Person();
            stamat.Name = "Stamat";
            stamat.Age = 43;
            
            Person gosho = new Person();
            Console.WriteLine(gosho.Name);
            Console.WriteLine(gosho.Age);
            
            Person petkan = new Person(23);
            Console.WriteLine(petkan.Name);
            Console.WriteLine(petkan.Age);
            
            Person lilian = new Person("Lilian");
            Console.WriteLine(lilian.Name);
            Console.WriteLine(lilian.Age);
            
            Person nicol = new Person("Nicol", 19);
            Console.WriteLine(nicol.Name);
            Console.WriteLine(nicol.Age);
        }
    }
}
