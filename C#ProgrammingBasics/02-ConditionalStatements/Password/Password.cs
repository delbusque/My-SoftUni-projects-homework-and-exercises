using System;

namespace Password
{
    class Password
    {
        static void Main(string[] args)
        {
            string pass = (Console.ReadLine());

            if (pass == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
                Console.WriteLine("Wrong password!");
        }
    }
}
