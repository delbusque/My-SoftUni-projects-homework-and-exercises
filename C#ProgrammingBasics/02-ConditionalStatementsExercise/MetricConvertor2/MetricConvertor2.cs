using System;

namespace MetricConvertor2
{
    class MetricConvertor2
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();

            double result = 0;

            if (inputUnit == "mm")
            {
                if (outputUnit == "m")
                {
                    result = value / 1000;
                }
                else if (outputUnit == "cm")
                {
                    result = value / 10;
                }
                else if (outputUnit == "mm")
                {
                    result = value;
                }
            }


            else if (inputUnit == "m")
            {
                if (outputUnit == "cm")
                {
                    result = value * 100;
                }
                else if (outputUnit == "mm")
                {
                    result = value * 1000;
                }
                else if (outputUnit == "m")
                {
                    result = value;
                }
                }
            else if (inputUnit == "cm")
            {
                if (outputUnit == "cm")
                {
                    result = value;
                }
                else if (outputUnit == "mm")
                {
                    result = value * 10;
                }
                else if (outputUnit == "m")
                {
                    result = value / 100;
                }
            }

            Console.WriteLine($"{result:f3}");

            }
    }
}
