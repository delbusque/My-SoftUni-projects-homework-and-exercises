using System;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<string> scale = new EqualityScale<string>("pesho", "pesho");

            bool result = scale.AreEqual();
            Console.WriteLine(result);
        }
    }
}
