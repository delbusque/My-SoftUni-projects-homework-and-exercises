using System;

namespace Password
{
    class Password
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string pass = Console.ReadLine();

            while (true)
            {
                string confirmPass = Console.ReadLine();

                if (confirmPass == pass)

                {
                    Console.WriteLine($"Welcome {user}!");
                    break;
                }

            }

        }
    }
}