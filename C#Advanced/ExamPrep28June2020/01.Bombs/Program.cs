using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> bombEffects =  new Queue<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            Stack<int> bombCasings = new Stack<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            int datura = 40;
            int cherry = 60;
            int smokeDecoy = 120;

            int daturaBombs = 0;
            int cheryBombs = 0;
            int smokeDecoyBombs = 0;

            while (bombEffects.Count != 0 && bombCasings.Count != 0)
            {
                if (daturaBombs < 3 || cheryBombs < 3 || smokeDecoyBombs < 3)               
                {
                    int currEffect = bombEffects.Peek();
                    int currCasing = bombCasings.Peek();
                    bool daturaReady = currCasing + currEffect == datura;
                    bool cherryReady = currCasing + currEffect == cherry;
                    bool smokeDecoyReady = currCasing + currEffect == smokeDecoy;

                    if (daturaReady)
                    {
                        bombEffects.Dequeue();
                        bombCasings.Pop();
                        daturaBombs++;
                    }
                    
                    else if (cherryReady)
                    {
                        bombEffects.Dequeue();
                        bombCasings.Pop();
                        cheryBombs++;
                    }
                    
                    else if (smokeDecoyReady)
                    {
                        bombEffects.Dequeue();
                        bombCasings.Pop();
                        smokeDecoyBombs++;
                    }
                    
                    else
                    {
                        if (currCasing == 0)
                        {
                            bombCasings.Pop();
                            continue;
                        }

                        currCasing -= 5;
                        if (currCasing < 0)
                        {
                            currCasing = 0;
                        }
                        bombCasings.Pop();
                        bombCasings.Push(currCasing);
                    }
                }
                else
                {
                    Console.WriteLine("Bene! You have successfully filled the bomb pouch!");                   
                    Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffects)}");
                    Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasings)}");
                    break;
                }
            }

            if (bombEffects.Count == 0 || bombCasings.Count == 0)
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");

                if (bombEffects.Count == 0)
                {
                    Console.WriteLine("Bomb Effects: empty");
                }
                if (bombCasings.Count == 0)
                {
                    Console.WriteLine("Bomb Casings: empty");
                } 
            }

            Console.WriteLine($"Cherry Bombs: {cheryBombs}"); 
            Console.WriteLine($"Datura Bombs: {daturaBombs}");            
            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBombs}");
        }
    }
}
