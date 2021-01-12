using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int logs = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentsBook = new Dictionary<string, List<double>>();

            for (int i = 0; i < logs; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsBook.ContainsKey(name))
                {
                    studentsBook.Add(name, new List<double>());
                    studentsBook[name].Add(grade);
                }
                else
                {
                    studentsBook[name].Add(grade);
                }
            }

            Dictionary<string, double> RevisedStudentsBook = new Dictionary<string, double>();


            foreach (var item in studentsBook)
            {
                double averageGrade = item.Value.Average();

                if (averageGrade >= 4.50)
                {
                    RevisedStudentsBook.Add(item.Key, averageGrade);                  
                }
            }

            foreach (var item in RevisedStudentsBook.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
