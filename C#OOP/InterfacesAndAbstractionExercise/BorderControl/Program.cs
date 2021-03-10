using System;
using System.Collections.Generic;

namespace BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            List<IIdentifiable> borderList = new List<IIdentifiable>();

            while (input[0] != "End")
            {
                
                if (input.Length == 3)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string id = input[2];
                    Citizen citizen = new Citizen(name, age, id);
                    borderList.Add(citizen);
                }
                else
                {
                    string name = input[0];
                    string id = input[1];
                    Robot robot = new Robot(name, id);
                    borderList.Add(robot);
                }

                input = Console.ReadLine().Split();
            }

            string lastIdDigits = Console.ReadLine();

            foreach (var forCheck in borderList)
            {
                string forCheckLastDigits = forCheck.Id.Substring(forCheck.Id.Length - lastIdDigits.Length);

                if (lastIdDigits == forCheckLastDigits)
                {
                    Console.WriteLine(forCheck.Id);
                }
            }

        }
    }
}
