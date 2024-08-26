namespace Drawing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrawingMachine machine = new DrawingMachine();
            machine.Draw(new Trapec());
        }
    }
}
