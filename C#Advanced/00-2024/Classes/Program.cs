namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Eathan", "Lucas", "Noah", "StanleyRoyce" };

            Array.ForEach(names, printNames);
        }

        static Action<string> printNames = name => Console.WriteLine($"Sir {name}");


    }
}
