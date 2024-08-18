Equals<int> equality = new (1, 1);

Console.WriteLine(equality.AreEqual());

Dictionary<string, int> dic = new (){{"1",1}, { "12", 1 } };


public class Equals<T>
    where T : struct
{
    private T first;
    private T second;

    public Equals(T first, T second)
    {
        this.first = first;
        this.second = second;
    }

    public bool AreEqual()
    {
        return first.Equals(second);
    }
}