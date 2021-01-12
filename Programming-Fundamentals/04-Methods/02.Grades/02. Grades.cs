﻿using System;

namespace _02.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            Grades(grade);
        }

        static void Grades(double grade)
        {
            string gradeInWords = String.Empty;

            if (grade >= 2.00 && grade <= 2.99)
            {
                gradeInWords = "Fail";
            }

            else if (grade >= 3.00 && grade <= 3.49)
            {
                gradeInWords = "Poor";
            }

            else if (grade >= 3.50 && grade <= 4.49)
            {
                gradeInWords = "Good";
            }

            else if (grade >= 4.50 && grade <= 5.49)
            {
                gradeInWords = "Very good";
            }

            else if (grade >= 5.50 && grade <= 6.00)
            {
                gradeInWords = "Excellent";
            }

            Console.WriteLine(gradeInWords);
        }
    }
}
