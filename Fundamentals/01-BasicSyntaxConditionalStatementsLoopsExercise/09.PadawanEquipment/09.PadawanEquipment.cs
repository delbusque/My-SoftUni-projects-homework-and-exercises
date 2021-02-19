using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltrPrice = double.Parse(Console.ReadLine());

            double extraLightsabres = Math.Ceiling(students * 0.1);
            double lightSabresExpence = (students + extraLightsabres) * lightsaberPrice;

            double robesExpence = students * robePrice;

            double freeBelts = Math.Floor(1.0 * students / 6);
            double beltsExpence = (students - freeBelts) * beltrPrice;

            double totalExpence = robesExpence + beltsExpence + lightSabresExpence;


            if (budget >= totalExpence)
            {
                Console.WriteLine($"The money is enough - it would cost {totalExpence:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalExpence - budget:f2}lv more.");
            }
        }
    }
}
