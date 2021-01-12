using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            

         

        }

        static void PassChecker(string pass)
        {
            string password = Console.ReadLine();
       
            bool invalid = false;
            
            if (pass.Length < 6 || pass.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                invalid = true;
            }

            if (CharChecker(password) == false)
            {

            }


            static bool CharChecker(string password)
            {
                bool invalid = false;

                for (int i = 0; i < password.Length; i++)
                {
                    if ((char)password[i] >= 48 && (char)password[i] <= 57 || (char)password[i] >= 65 && (char)password[i] <= 90 || (char)password[i] >= 97 && (char)password[i] <= 122)
                    {
                        invalid = false;
                    }
                    else
                    {
                        Console.WriteLine("Password must consist only of letters and digits");
                        invalid = true;
                        break;
                    }
                }

                return invalid;
            }

            static bool DigitChecker(string password)
            {
                bool invalid = false;
                int digitCount = 0;

                for (int i = 0; i < password.Length; i++)
                {
                    if ((char)password[i] >= 48 && (char)password[i] <= 57)
                    {
                        digitCount++;
                    }
                }

                if (digitCount < 2)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                    invalid = false;
                }
                else
                {
                    invalid = true;
                }

                return invalid;
            }


        }

        
    }
}

