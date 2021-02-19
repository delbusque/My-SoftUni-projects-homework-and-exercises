using System;
using System.Numerics;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling(people * 1.0 / capacity);

            Console.WriteLine(courses);
        }
    }
}
