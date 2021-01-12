using System;

namespace WeddingSeats
{
    class WeddingSeats
    {
        static void Main(string[] args)
        {
            char lastUnit = char.Parse(Console.ReadLine());
            int rowsFirstSector = int.Parse(Console.ReadLine());
            int columnsOddRows = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int unit = 'A'; unit <= lastUnit; unit++)
            {
               
                for (int row = 1; row <= rowsFirstSector; row++)
                {
                    
                    if (row % 2 == 0)
                    {
                        
                        for (int col = 'a'; col <= 96 + (columnsOddRows + 2); col++)
                        {
                            char a = Convert.ToChar(unit);
                            char b = Convert.ToChar(col);
                            Console.WriteLine($"{a}{row}{b}");
                            counter++;
                        }

                    }

                    else
                    {
                        
                        for (int col = 'a'; col <= 96 + columnsOddRows; col++)
                        {
                            char a = Convert.ToChar(unit);
                            char b = Convert.ToChar(col);
                            Console.WriteLine($"{a}{row}{b}");
                            counter++;
                        }
                    }
                }

                rowsFirstSector++;
            }

            Console.WriteLine(counter);
        }
    }
}

