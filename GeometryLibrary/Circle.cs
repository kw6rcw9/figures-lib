namespace GeometryLibrary;

public class Circle: IFigure
{
    private double _radius;
    public Circle( double radius)
    {
        _radius = radius;
    }
    public void CalculateSquare()
    {
        if (_radius <= 0)
            throw new ArgumentException("A circle cannot have such radius");
        double square = Math.Round(Math.PI * Math.Pow(_radius, 2), 2);
        Console.WriteLine($"Circle`s square is {square}");
    }
}