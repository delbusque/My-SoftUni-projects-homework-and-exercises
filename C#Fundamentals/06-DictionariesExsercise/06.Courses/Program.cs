using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] test = Console.ReadLine().Split(" : ");

            Dictionary<string, List<string>> coursesData = new Dictionary<string, List<string>>();

            while (test[0] != "end")
            {
                string course = test[0];
                string name = test[1];

                if (!coursesData.ContainsKey(course))
                {
                    coursesData.Add(course, new List<string>());
                    coursesData[course].Add(name);
                }
                else
                {
                    coursesData[course].Add(name);
                    coursesData[course].Sort();
                }


                test = Console.ReadLine().Split(" : ");
            }

            

            foreach (var item in coursesData.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");

                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.WriteLine($"-- {item.Value[i]}");
                }
                
            }
        }
    }
}
