using System;

namespace BasicSyntaxConditionalStatementsLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double mark = double.Parse(Console.ReadLine());

            //"Name: {student name}, Age: {student age}, Grade: {student grade}".

            Console.WriteLine("Name: {0}, Age: {1}, Grade: {2:f2}", name, age, mark);

            // Console.WriteLine($"Name: {name}, Age: {age}, Grade: {mark:f2}");
        }
    }
}
