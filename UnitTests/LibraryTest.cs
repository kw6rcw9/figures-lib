namespace UnitTests;
using GeometryLibrary;

public class LibraryTest
{
    [Test]
    public void RightTriangleTest()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.CheckOnRightTriangle());
    }

    [Test]
    public void CorrectRadiusTest()
    {
        Circle circle = new Circle(-1);
        Assert.Throws<ArgumentException>(circle.CalculateSquare);
    }

    [Test]
    public void CorrectSidesTest()
    {
        Triangle triangle = new Triangle(0, 4, 5);
        Assert.Throws<ArgumentException>(triangle.CalculateSquare);


    }

}