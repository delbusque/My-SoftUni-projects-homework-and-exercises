using System;

namespace SmallShop
{
    class SmallShop
    {
        static void Main(string[] args)
        {
            string good = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            switch (town)
            {
                case "Sofia":
                    if (good == "coffee")
                    {
                        double price = 0.50;
                        Console.WriteLine($"{quantity * price:f2}");
                    }

                    else if (good == "water")
                    {
                        double price = 0.80;
                        Console.WriteLine($"{quantity * price:f2}");
                    }

                    else if (good == "beer")
                    {
                        double price = 1.20;
                        Console.WriteLine($"{quantity * price:f2}");
                    }
                    else if (good == "sweets")
                    {
                        double price = 1.45;
                        Console.WriteLine($"{quantity * price:f2}");
                      }
                    else if (good == "peanuts")
                    {
                        double price = 1.60;
                        Console.WriteLine($"{quantity * price:f2}");
                    }
                    break;
              

                case "Plovdiv":
                    if (good == "coffee")
                    {
                        double price = 0.40;
                        Console.WriteLine($"{quantity * price:f2}");
                    }

                    else if (good == "water")
                    {
                        double price = 0.70;
                        Console.WriteLine($"{quantity * price:f2}");
                    }

                    else if (good == "beer")
                    {
                        double price = 1.15;
                        Console.WriteLine($"{quantity * price:f2}");
                    }
                    else if (good == "sweets")
                    {
                        double price = 1.30;
                        Console.WriteLine($"{quantity * price:f2}");
                    }
                    else if (good == "peanuts")
                    {
                        double price = 1.50;
                        Console.WriteLine($"{quantity * price:f2}");
                    }
                    break;

                case "Varna":
                    if (good == "coffee")
                    {
                        double price = 0.45;
                        Console.WriteLine($"{quantity * price:f2}");
                    }

                    else if (good == "water")
                    {
                        double price = 0.70;
                        Console.WriteLine($"{quantity * price:f2}");
                    }

                    else if (good == "beer")
                    {
                        double price = 1.10;
                        Console.WriteLine($"{quantity * price:f2}");
                    }
                    else if (good == "sweets")
                    {
                        double price = 1.35;
                        Console.WriteLine($"{quantity * price:f2}");
                    }
                    else if (good == "peanuts")
                    {
                        double price = 1.55;
                        Console.WriteLine($"{quantity * price:f2}");
                    }
                    break;



                default:

                    break;
            }


        }
    }
}
