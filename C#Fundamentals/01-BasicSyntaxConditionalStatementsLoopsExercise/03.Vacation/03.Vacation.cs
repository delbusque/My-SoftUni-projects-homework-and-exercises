using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());
            string type = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();

            double totalPrice = 0;

            if (type == "students")
            {
                if (group >= 30)
                {
                    switch (day)
                    {
                        case "friday":
                            totalPrice = group * 8.45 * 0.85;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                            break;
                        case "saturday":
                            totalPrice = group * 9.80 * 0.85;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                            break;
                        case "sunday":
                            totalPrice = group * 10.46 * 0.85;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                            break;
                    }
                }

                else
                {
                    switch (day)
                    {
                        case "friday":
                            totalPrice = group * 8.45;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                            break;
                        case "saturday":
                            totalPrice = group * 9.80;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                            break;
                        case "sunday":
                            totalPrice = group * 10.46;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                            break;
                    }
                }
                
            }

            if (type == "business")
            {
                if (group >= 100)
                {
                    switch (day)
                    {
                        case "friday":
                            totalPrice = (group - 10) * 10.90;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                            break;
                        case "saturday":
                            totalPrice = (group - 10) * 15.60;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                            break;
                        case "sunday":
                            totalPrice = (group - 10) * 16;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                            break;
                    }
                }

                else
                {
                    switch (day)
                    {
                        case "friday":
                            totalPrice = group * 10.90;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                            break;
                        case "saturday":
                            totalPrice = group * 15.60;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                            break;
                        case "sunday":
                            totalPrice = group * 16;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                            break;
                    }
                }
                
            }

            if (type == "regular")
            {

                if (group >= 10 && group <= 20)
                {
                    switch (day)
                    {
                        case "friday":
                            totalPrice = group * 15 * 0.95;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                            break;
                        case "saturday":
                            totalPrice = group * 20 * 0.95;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                            break;
                        case "sunday":
                            totalPrice = group * 22.50 * 0.95;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                            break;
                    }
                }

                else
                {
                    switch (day)
                    {
                        case "friday":
                            totalPrice = group * 15;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                            break;
                        case "saturday":
                            totalPrice = group * 20;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                            break;
                        case "sunday":
                            totalPrice = group * 22.50;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                            break;
                    }
                }               
            }
        }
    }
}
