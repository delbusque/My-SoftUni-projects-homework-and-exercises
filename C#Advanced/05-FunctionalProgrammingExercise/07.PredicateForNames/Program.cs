using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();

            Func<string, int, bool> func = (name, lenght) => name.Length <= lenght;

            names = names.Where(name => func(name, n)).ToList();
                       
            Action<List<string>> print = name => Console.WriteLine(string.Join(Environment.NewLine, names));

            print(names);      
        }        
    }
}
