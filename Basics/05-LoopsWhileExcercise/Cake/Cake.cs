using System;

namespace Cake
{
    class Cake
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int cakeArea = lenght * width;
            int cakePiece = 1 * 1;

            int cakePiecesArea = 0;

            string command = Console.ReadLine();

            while (command != "STOP")
            {
                
                int currentPieces = int.Parse(command);
                cakePiecesArea += currentPieces * cakePiece;

                if (cakePiecesArea >= cakeArea)
                {
                    int more = cakePiecesArea - cakeArea;
                    Console.WriteLine($"No more cake left! You need {more} pieces more.");
                    break;
                }               

                command = Console.ReadLine();
            }

            if (cakePiecesArea < cakeArea)
            {
                int more = cakeArea - cakePiecesArea;
                Console.WriteLine($"{more} pieces are left.");
            }
        }
    }
}
