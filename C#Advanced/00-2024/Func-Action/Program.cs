using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Func<int, int> multiply = Multi;
        Action<string> text = word => Console.WriteLine(word);

        Console.WriteLine(multiply(10));
        text("Wtf");

        string[] names = { "Eathan", "Lucas", "Noah", "StanleyRoyce" };

        Array.ForEach(names, printNames);

        Array.ForEach(names, name => Console.WriteLine(nameStarter(name)));
    }

    static Action<string> printNames = name => Console.WriteLine($"Sir {name}");
    public static int Multi(int b)
    {
        return b * 100;
    }

    static Predicate<string> nameStarter = name => name.StartsWith("A");

}