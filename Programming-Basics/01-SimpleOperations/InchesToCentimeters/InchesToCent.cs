using System;

namespace InchesToCentimeters
{
    class InchesToCent
    {
        static void Main()
        {

            double inches = double.Parse(Console.ReadLine());
            double centimeters = inches * 2.54;

            Console.WriteLine(centimeters);
        }
    }
}
