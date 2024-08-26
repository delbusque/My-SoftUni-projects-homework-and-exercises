using Drawing.Contracts;

namespace Drawing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle();

            DrawingMachine machine = new DrawingMachine();
            
            machine.Draw(circle);
            machine.Draw(new Trapec());
            
        }
    }
}
