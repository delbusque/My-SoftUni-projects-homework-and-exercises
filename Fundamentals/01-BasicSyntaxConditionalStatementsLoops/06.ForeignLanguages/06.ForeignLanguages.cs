using System;

namespace _06.ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine().ToLower();
            string language = "";

            switch (country)
            {
                case "england":
                case "usa":
                    language = "English"; break;
                case "spain":
                case "argentina":
                case "mexico":
                    language = "Spanish"; break;

                default: language = "unknown"; break;
            }

            Console.WriteLine(language);

        }
    }
}
