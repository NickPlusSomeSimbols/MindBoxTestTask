using FiguresLibrary;

namespace MindBoxTestTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle_1 = new Triangle(3, 3, 3);
            Circle circle_1 = new Circle(4);

            Console.WriteLine(circle_1.CalculateArea());
            Console.WriteLine(triangle_1.CalculateArea());
        }
    }
}