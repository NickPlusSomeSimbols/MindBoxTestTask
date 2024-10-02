namespace FiguresLibrary;

public interface IShape
{
    public double CalculateArea();
}
public class Triangle : IShape
{
    private float SideA { get; set; }
    private float SideB { get; set; }
    private float SideC { get; set; }

    public Triangle(float sideA, float sideB, float sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public double CalculateArea()
    {
        double semiPerimeter = (SideA + SideB + SideC) / 2;

        return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
    }

    public bool IsTriangleRight(float a, float b, float c)
    {
        float[] arr = { a, b, c };
        Array.Sort(arr);

        return arr[0] * arr[0] + arr[1] * arr[1] == arr[2] * arr[2];
    }
}
public class Circle : IShape
{
    private const double Pi = Math.PI;
    private float Radius { get; set; }

    public Circle(float radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Pi * Radius * Radius;
    }
}
