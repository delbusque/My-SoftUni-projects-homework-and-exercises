using System;

namespace DancingHall
{
    class DancingHall
    {
        static void Main()
        {
            double hallLenght = double.Parse(Console.ReadLine());
            double hallWidth= double.Parse(Console.ReadLine());
            double WardrobeLenght = double.Parse(Console.ReadLine());
            
            double wardrobeArea = WardrobeLenght * 100 * WardrobeLenght * 100;
            double benchArea = hallLenght * 100 * hallWidth * 100 / 10;

            double freeHallArea = (hallLenght * 100 * hallWidth * 100) - wardrobeArea - benchArea;
            double dancerArea = 7040;

            double dancers = freeHallArea / 7040;

            Console.WriteLine(Math.Floor(dancers));
        }
    }
}
