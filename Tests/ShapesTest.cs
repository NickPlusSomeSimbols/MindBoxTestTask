using FiguresLibrary;

namespace Tests;

public class ShapesTest
{
    [Theory]
    [InlineData(1, Math.PI)] 
    [InlineData(2, Math.PI * 4)] 
    [InlineData(5, Math.PI * 25)]
    public void CircleAreaTest(float radius, float expected)
    {  
        var circle = new Circle(radius);
        
        double area = circle.CalculateArea();

        Assert.Equal(expected, area, 4); 
    }

    [Theory]
    [InlineData(3, 4, 5, 6)] 
    [InlineData(6, 8, 10, 24)] 
    [InlineData(7, 24, 25, 84)]
    public void TriangleAreaTest(float sideA, float sideB, float sideC, double expected)
    {
        var triangle = new Triangle(sideA, sideB, sideC);

        double area = triangle.CalculateArea();

        Assert.Equal(expected, area, 4);
    }

    [Theory]
    [InlineData(3, 4, 5, true)] 
    [InlineData(6, 8, 10, true)]
    [InlineData(5, 5, 5, false)]
    public void IsTriangleRight(float sideA, float sideB, float sideC, bool expected)
    {
        var triangle = new Triangle(sideA, sideB, sideC);

        bool isRight = triangle.IsTriangleRight(sideA,sideB,sideC);

        Assert.Equal(expected, isRight);
    }
}