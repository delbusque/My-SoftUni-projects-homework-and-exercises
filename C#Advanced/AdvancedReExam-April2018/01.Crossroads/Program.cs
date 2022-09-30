using System;
using System.Collections.Generic;

namespace _01.Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            byte greenLight = byte.Parse(Console.ReadLine());
            byte freeWindow = byte.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            int totalCarsPassed = 0;

            while (command != "END")
            {
                if (command != "green")
                {
                    cars.Enqueue(command);                    
                }
                else
                {
                    int passTime = greenLight + freeWindow;

                    
                        string currentCar = cars.Peek();
                        
                        if (currentCar.Length <= greenLight)
                        {
                            char[] car = cars.Dequeue().ToCharArray();

                            Stack<char> carStack = new Stack<char>();
                            for (int i = 0; i < car.Length; i++)
                            {
                                passTime--;

                                if (passTime > 0)
                                {
                                    carStack.Push(car[i]);
                                }
                                else
                                {
                                    Console.WriteLine("A crash happened!");
                                    Console.WriteLine($"{car} was hit at {i}.");
                                }
                            }

                            totalCarsPassed++;
                            if (cars.Count == 0)
                            {
                                break;
                            }
                        }
                        else
                        {
                            break;
                        }
                                                          
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");
        }
    }
}
