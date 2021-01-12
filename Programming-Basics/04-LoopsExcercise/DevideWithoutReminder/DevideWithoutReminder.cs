using System;

namespace DevideWithoutReminder
{
    class DevideWithoutReminder
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int group_2 = 0;
            int group_3 = 0;
            int group_4 = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    group_2 += 1;
                }

                if (num % 3 == 0)
                {
                    group_3 += 1;
                }

                if (num % 4 == 0)
                {
                    group_4 += 1;
                }

            }

            double perc_2 = 100.00 * group_2 / n;
            double perc_3 = 100.00 * group_3 / n;
            double perc_4 = 100.00 * group_4 / n;

            Console.WriteLine($"{perc_2:f2}%");
            Console.WriteLine($"{perc_3:f2}%");
            Console.WriteLine($"{perc_4:f2}%");

        }
    }
}
