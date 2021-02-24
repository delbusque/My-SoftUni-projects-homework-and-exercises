using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book
    {
        public Book(string name, int year, params string[] authors)
        {
            Name = name;
            Year = year;
            Authors = authors;

        }
        
        public string Name { get; set; }
        public int Year { get; set; }
        public IReadOnlyList<string> Authors { get; set; }


    }
}
