using System;

namespace _02.Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] field = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                string line = Console.ReadLine();

                for (int col = 0; col < size; col++)
                {
                    field[row, col] = line[col];
                }
            }

            string command = Console.ReadLine();
            int polinatedFlowers = 0;

            bool gotLost = false;

            while (command != "End")
            {
                if (gotLost)
                {
                    break;
                }

                for (int row = 0; row < size; row++)
                {
                    if (gotLost)
                    {
                        break;
                    }
                    
                    for (int col = 0; col < size; col++)
                    {
                        if (field[row, col] == 'B')
                        {
                            switch (command)
                            {
                                case "right":
                                    if (col + 1 >= size)
                                    {
                                        field[row, col] = '.';
                                        Console.WriteLine("The bee got lost!");
                                        gotLost = true;
                                        continue;
                                    }
                                    else
                                    {
                                        if (field[row, col + 1] == 'f')
                                        {
                                            polinatedFlowers++;
                                            field[row, col] = '.';
                                            field[row, col + 1] = 'B';
                                        }
                                        else if (field[row, col + 1] == '.')
                                        {
                                            field[row, col] = '.';
                                            field[row, col + 1] = 'B';
                                        }
                                        else if (field[row, col + 1] == 'O')
                                        {
                                            field[row, col] = '.';
                                            field[row, col + 1] = '.';

                                            if (col + 2 >= size)
                                            {
                                                Console.WriteLine("The bee got lost!");
                                                gotLost = true;
                                                continue;
                                            }
                                            else
                                            {
                                                if (field[row, col + 2] == 'f')
                                                {
                                                    polinatedFlowers++;
                                                }
                                                field[row, col + 2] = 'B';
                                            }
                                        }
                                    }
                                    break;

                                case "left":
                                    if (col - 1 < 0)
                                    {
                                        field[row, col] = '.';
                                        Console.WriteLine("The bee got lost!");
                                        gotLost = true;
                                        continue;
                                    }
                                    else
                                    {
                                        if (field[row, col - 1] == 'f')
                                        {
                                            polinatedFlowers++;
                                            field[row, col] = '.';
                                            field[row, col - 1] = 'B';
                                        }
                                        else if (field[row, col - 1] == '.')
                                        {
                                            field[row, col] = '.';
                                            field[row, col - 1] = 'B';
                                        }
                                        else if (field[row, col - 1] == 'O')
                                        {
                                            field[row, col] = '.';
                                            field[row, col - 1] = '.';

                                            if (col - 2 < 0)
                                            {
                                                Console.WriteLine("The bee got lost!");
                                                gotLost = true;
                                                continue;
                                            }
                                            else
                                            {
                                                if (field[row, col - 2] == 'f')
                                                {
                                                    polinatedFlowers++;
                                                }
                                                field[row, col - 2] = 'B';
                                            }
                                        }
                                    }
                                    break;

                                case "down":
                                    if (row + 1 >= size)
                                    {
                                        field[row, col] = '.';
                                        Console.WriteLine("The bee got lost!");
                                        gotLost = true;
                                        continue;
                                    }
                                    else
                                    {
                                        if (field[row+1, col] == 'f')
                                        {
                                            polinatedFlowers++;
                                            field[row, col] = '.';
                                            field[row+1, col] = 'B';
                                        }
                                        else if (field[row + 1, col] == '.')
                                        {
                                            field[row, col] = '.';
                                            field[row + 1, col] = 'B';
                                        }
                                        else if (field[row+1, col] == 'O')
                                        {
                                            field[row, col] = '.';
                                            field[row+1, col] = '.';

                                            if (row + 2 >= size)
                                            {
                                                Console.WriteLine("The bee got lost!");
                                                gotLost = true;
                                                continue;
                                            }
                                            else
                                            {
                                                if (field[row + 2, col] == 'f')
                                                {
                                                    polinatedFlowers++;
                                                }
                                                field[row+2, col] = 'B';
                                            }
                                        }
                                    }
                                    break;

                                case "up":
                                    if (row - 1 < 0)
                                    {
                                        field[row, col] = '.';
                                        Console.WriteLine("The bee got lost!");
                                        gotLost = true;
                                        continue;
                                    }
                                    else
                                    {
                                        if (field[row - 1, col] == 'f')
                                        {
                                            polinatedFlowers++;
                                            field[row, col] = '.';
                                            field[row - 1, col] = 'B';
                                        }
                                        else if (field[row - 1, col] == '.')
                                        {
                                            field[row, col] = '.';
                                            field[row - 1, col] = 'B';
                                        }
                                        else if (field[row - 1, col] == 'O')
                                        {
                                            field[row, col] = '.';
                                            field[row - 1, col] = '.';

                                            if (row - 2 < 0)
                                            {
                                                Console.WriteLine("The bee got lost!");
                                                gotLost = true;
                                                continue;
                                            }
                                            else
                                            {
                                                if (field[row - 2, col] == 'f')
                                                {
                                                    polinatedFlowers++;
                                                }
                                                field[row - 2, col] = 'B';
                                            }
                                        }
                                    }
                                    break;
                            }

                            command = Console.ReadLine();

                        }
                    }
                }
               
            }

            if (polinatedFlowers >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {polinatedFlowers} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - polinatedFlowers} flowers more");
            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(string.Join("", field[row, col]));
                }
                Console.WriteLine();
            }
        }    
    }
}
