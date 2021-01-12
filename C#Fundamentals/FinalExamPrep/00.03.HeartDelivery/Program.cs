using System;
using System.Linq;

namespace _00._03.HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighbourhood = Console.ReadLine().Split("@").Select(int.Parse).ToArray();

            string[] cmdArgs = Console.ReadLine().Split();

            int startingPosition = 0;
            int lastPosition = 0;
            int celebrateCount = 0;
            int landingPosition = 0;

            while (cmdArgs[0] != "Love!")
            {
                int jumpLenght = int.Parse(cmdArgs[1]);

                landingPosition = startingPosition + jumpLenght;

                if (landingPosition > neighbourhood.Length - 1)
                {
                    landingPosition = startingPosition;
                    
                    if (neighbourhood[landingPosition] == 0)
                    {
                        Console.WriteLine($"Place {neighbourhood[landingPosition]} already had Valentine's day.");
                        lastPosition = landingPosition;
                        startingPosition = landingPosition;
                        celebrateCount++;
                    }

                    else
                    {
                        if (landingPosition <= neighbourhood.Length - 1)
                        {
                            neighbourhood[landingPosition] -= 2;
                            startingPosition = landingPosition;

                            if (neighbourhood[landingPosition] == 0)
                            {
                                Console.WriteLine($"Place {landingPosition} has Valentine's day.");
                                lastPosition = landingPosition;
                                celebrateCount++;
                            }
                        }

                        else
                        {
                            neighbourhood[landingPosition] -= 2;

                            if (neighbourhood[landingPosition] == 0)
                            {
                                Console.WriteLine($"Place {landingPosition} has Valentine's day.");
                                lastPosition = landingPosition;
                                startingPosition = landingPosition;
                                celebrateCount++;
                            }
                        }

                    }
                }

                else
                {
                    if (neighbourhood[landingPosition] == 0)
                    {
                        Console.WriteLine($"Place {neighbourhood[landingPosition]} already had Valentine's day.");
                        lastPosition = landingPosition;
                        startingPosition = landingPosition;
                        celebrateCount++;
                    }

                    else
                    {
                        if (landingPosition <= neighbourhood.Length - 1)
                        {
                            neighbourhood[landingPosition] -= 2;
                            startingPosition = landingPosition;

                            if (neighbourhood[landingPosition] == 0)
                            {
                                Console.WriteLine($"Place {landingPosition} has Valentine's day.");
                                lastPosition = landingPosition;
                                celebrateCount++;
                            }
                        }

                        else
                        {
                            neighbourhood[landingPosition] -= 2;

                            if (neighbourhood[landingPosition] == 0)
                            {
                                Console.WriteLine($"Place {landingPosition} has Valentine's day.");
                                lastPosition = landingPosition;
                                startingPosition = landingPosition;
                                celebrateCount++;
                            }
                        }

                    }
                }

                cmdArgs = Console.ReadLine().Split();
            }

            Console.WriteLine($"Cupid's last position was {lastPosition}.");

            int nonCelebrated = neighbourhood.Length - celebrateCount;

            if (nonCelebrated > 0)
            {
                Console.WriteLine($"Cupid has failed {nonCelebrated} places.");
            }
            else
            {
                Console.WriteLine($"Mission was successful.");
            }
        }
    }
}
