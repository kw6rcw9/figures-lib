namespace GeometryLibrary;

public class Triangle: IFigure
{
    private double _aSide;
    private double _bSide;
    private double _cSide;
    public Triangle(double aSide, double bSide, double cSide )
    {
        _aSide = aSide;
        _bSide = bSide;
        _cSide = cSide;
    }
    public void CalculateSquare()
    {
        if (_aSide <= 0 
            || _bSide <= 0 
            || _cSide <= 0)
            throw new ArgumentException("A triangle cannot have a side below or equals zero ");
        if(CheckOnRightTriangle())
            Console.WriteLine("Triangle is right.");
        double p = (_aSide + _bSide + _cSide) / 2;
        double square = Math.Round(Math.Sqrt(p * (p - _aSide) * (p - _bSide) * (p - _cSide)), 2);
        Console.WriteLine($"Triangle`s square is {square}");
    }

    public bool CheckOnRightTriangle()
    {
        if (Math.Pow(_aSide, 2) + Math.Pow(_bSide, 2) == Math.Pow(_cSide, 2))
            return true;
        if (Math.Pow(_bSide, 2) + Math.Pow(_cSide, 2) == Math.Pow(_aSide, 2))
            return true;
        if (Math.Pow(_aSide, 2) + Math.Pow(_cSide, 2) == Math.Pow(_bSide, 2))
            return true;

        return false;
    }
}