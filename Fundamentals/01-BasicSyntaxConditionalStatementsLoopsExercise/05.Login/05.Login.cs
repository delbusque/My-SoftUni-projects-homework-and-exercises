using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();

            string password = "";

            for (int i = user.Length - 1; i >= 0; i--)
            {
                password += user[i];
            }

            string currentPassword = Console.ReadLine();
            int counter = 0;

            while (password != currentPassword)
            {
                counter++;

                if (counter == 4)
                {
                    Console.WriteLine($"User {user} blocked!");
                    Environment.Exit(0);
                }

                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    currentPassword = Console.ReadLine();
                }                                                            
            }

            Console.WriteLine($"User {user} logged in.");
        }
    }
}
