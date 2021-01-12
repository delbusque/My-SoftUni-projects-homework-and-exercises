using System;

namespace ConsoleApp1
{
    class OldBooks
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            int libraryCapacity = int.Parse(Console.ReadLine());

            int bookCount = 0;
            string currentBook = ""; 

            while (searchedBook != currentBook)
            {
                currentBook = Console.ReadLine();
                bookCount++;

                if (bookCount > libraryCapacity)
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {libraryCapacity} books.");
                    break;
                }

                else if (searchedBook == currentBook)
                {                  
                    Console.WriteLine($"You checked {bookCount-1} books and found it.");
                }

            }  
        }
    }
}
