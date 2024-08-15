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
    }

static Action<string> printNames = name => Console.WriteLine($"Sir {name}");

public static int Multi(int b)
    {
        return b * 100;
    }

}