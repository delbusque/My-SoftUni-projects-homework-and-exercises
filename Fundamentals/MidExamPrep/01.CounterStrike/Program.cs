using System;

namespace _01.CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            int wins = 0;
            string command = Console.ReadLine();

            {

                while (command != "End of battle")
                {
                    int disctance = int.Parse(command);

                    energy -= disctance;
                    if (energy >= 0)
                    {
                        wins++;
                    }
                    else
                    {
                        if (energy < 0)
                        {
                            int energyd = energy + disctance;
                            Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {energyd} energy");
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {energy} energy");
                            Environment.Exit(0);
                        }
                        
                    }

                    if (wins % 3 == 0)
                    {
                        energy += wins;
                    }               

                    command = Console.ReadLine();
                }

                Console.WriteLine($"Won battles: {wins}. Energy left: {energy}");
            }
        }
    }
}
