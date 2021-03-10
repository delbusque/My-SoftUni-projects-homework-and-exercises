using System;

namespace ExplicitInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            while (input[0] != "End")
            {
                string name = input[0];
                string country = input[1];
                int age = int.Parse(input[2]);

                IResident residentIR = new Citizen(name, country, age);
                IPerson residentIP = new Citizen(name, country, age);

                Console.WriteLine(residentIP.GetName());
                Console.WriteLine(residentIR.GetName());

                input = Console.ReadLine().Split();
            }
        }
    }
}
