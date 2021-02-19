using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                int index = int.Parse(command[1]);

                if (command[0] == "Shoot")
                {
                    int power = int.Parse(command[2]);

                    if (index <= targets.Count-1)
                    {
                        targets[index] -= power;
                    }
                    else
                    {
                        command = Console.ReadLine().Split(); 
                        continue;
                    }

                    if (targets[index] <= 0)
                    {
                        targets.RemoveAt(index);
                    }
                }

                else if (command[0] == "Add")
                {
                    int value = int.Parse(command[2]); 
                    
                    if (index <= targets.Count - 1)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                    
                }

                else if (command[0] == "Strike")
                {
                    int radius = int.Parse(command[2]);
                    int startIndex = index - radius;
                    int countIndex = radius * 2 + 1;

                    if (index <= targets.Count - 1)
                    {
                        if (startIndex > 0 && countIndex < targets.Count-1)
                        {
                            targets.RemoveRange(startIndex, countIndex);
                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }

                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join("|", targets));

        }
    }
}
