using System;

namespace BasicSyntaxConditionalStatementsLoops_MoreExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal balance = decimal.Parse(Console.ReadLine());
            decimal spendings = 0;

            string command = Console.ReadLine();

            while (command != "Game Time")
            {

                switch (command)
                {

                    case "OutFall 4":
                    case "RoverWatch Origins Edition":
                        if (balance >= 39.99m)
                        {
                            balance -= 39.99m;
                            Console.WriteLine($"Bought {command}");
                            spendings += 39.99m;

                            if (balance == 0)
                            {
                                Console.WriteLine("Out of money!");
                                Environment.Exit(0);
                            }
                        }
                        else
                        {
                            if (balance == 0)
                            {
                                Console.WriteLine("Out of money!");
                                Environment.Exit(0);
                            }
                            Console.WriteLine("Too Expensive");
                        }
                        break;



                    case "CS: OG":
                        if (balance >= 15.99m)
                        {
                            balance -= 15.99m;
                            Console.WriteLine($"Bought {command}");
                            spendings += 15.99m;

                            if (balance == 0)
                            {
                                Console.WriteLine("Out of money!");
                                Environment.Exit(0);
                            }
                        }
                        else
                        {
                            if (balance == 0)
                            {
                                Console.WriteLine("Out of money!");
                                Environment.Exit(0);
                            }
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "Zplinter Zell":
                        if (balance >= 19.99m)
                        {
                            balance -= 19.99m;
                            Console.WriteLine($"Bought {command}");
                            spendings += 19.99m;

                            if (balance == 0)
                            {
                                Console.WriteLine("Out of money!");
                                Environment.Exit(0);
                            }
                        }
                        else
                        {
                            if (balance == 0)
                            {
                                Console.WriteLine("Out of money!");
                                Environment.Exit(0);
                            }
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "Honored 2":
                        if (balance >= 59.99m)
                        {
                            balance -= 59.99m;
                            Console.WriteLine($"Bought {command}");
                            spendings += 59.99m;

                            if (balance == 0)
                            {
                                Console.WriteLine("Out of money!");
                                Environment.Exit(0);
                            }
                        }
                        else
                        {
                            if (balance == 0)
                            {
                                Console.WriteLine("Out of money!");
                                Environment.Exit(0);
                            }
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    case "RoverWatch":
                        if (balance >= 29.99m)
                        {
                            balance -= 29.99m;
                            Console.WriteLine($"Bought {command}");
                            spendings += 29.99m;

                            if (balance == 0)
                            {
                                Console.WriteLine("Out of money!");
                                Environment.Exit(0);
                            }
                        }
                        else
                        {
                            if (balance == 0)
                            {
                                Console.WriteLine("Out of money!");
                                Environment.Exit(0);
                            }
                            Console.WriteLine("Too Expensive");
                        }
                        break;

                    default:
                        Console.WriteLine("Not Found");
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Total spent: ${spendings}. Remaining: ${balance}");

        }
    }
}
