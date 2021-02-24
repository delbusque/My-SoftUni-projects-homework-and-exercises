using System;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);

            Library libraryOne = new Library();
            Library libraryTwo = new Library(bookOne, bookTwo, bookThree);

            foreach (var item in libraryTwo)
            {
                
                if (item.Authors.Count == 0)
                {
                    Console.WriteLine($"{item.Name}, {item.Year}");
                }
                else
                {
                    Console.WriteLine($"{item.Name}, {item.Year}, {string.Join(" / ", item.Authors)}");
                }
            }         
        }
    }
}
