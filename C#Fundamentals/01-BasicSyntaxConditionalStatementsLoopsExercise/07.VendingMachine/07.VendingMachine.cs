using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine().ToLower();
            
            double sum = 0;

            while (command != "start")
            {
                double currentCoin = double.Parse(command);

                if (currentCoin != 0.1 && currentCoin != 0.2 && currentCoin != 0.5 && currentCoin != 1 && currentCoin != 2)
                {
                    Console.WriteLine($"Cannot accept {currentCoin}");
                    command = Console.ReadLine().ToLower();
                }
                else
                {
                    sum += currentCoin;
                    command = Console.ReadLine().ToLower();
                }
            }

            string item = Console.ReadLine().ToLower();
            double price = 0;

            while (item != "end")
            {
                switch (item)
                {
                    case "nuts": price = 2;
                        if (sum >= price)
                        {
                            Console.WriteLine($"Purchased {item}");
                            sum -= price;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;                        
                    case "water": price = 0.7;
                        if (sum >= price)
                        {
                            Console.WriteLine($"Purchased {item}");
                            sum -= price;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "crisps": price = 1.5;
                        if (sum >= price)
                        {
                            Console.WriteLine($"Purchased {item}");
                            sum -= price;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "soda": price = 0.8;
                        if (sum >= price)
                        {
                            Console.WriteLine($"Purchased {item}");
                            sum -= price;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "coke": price = 1;
                        if (sum >= price)
                        {
                            Console.WriteLine($"Purchased {item}");
                            sum -= price;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;                  
                }              

                if (item != "nuts" && item != "water" && item != "crisps" && item != "soda" && item != "coke")
                {
                    Console.WriteLine("Invalid product");
                }

                item = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
