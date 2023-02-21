namespace Mindbox.Squares.Library;

public class Triangle : IFigure, ITriangle
{
    public bool IsRightTriangle { get; }
    
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;
    private readonly double _perimeter;

    public Triangle(double sideA, double sideB, double sideC)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
        CheckingTheTriangleForReality();

        _perimeter = _sideA + _sideB + _sideC;
        
        IsRightTriangle = CheckingTheTriangleForRight();
    }
    
    public double GetSquare()
    {
        var p = _perimeter / 2;
        
        return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
    }
    
    private bool CheckingTheTriangleForRight()
    {
        var list = new[] {_sideA, _sideB, _sideC};
        var orderingArray = list.OrderByDescending(x => x).ToArray();

        return Math.Abs(orderingArray[0] - Math.Sqrt(Math.Pow(orderingArray[1], 2) + Math.Pow(orderingArray[2], 2))) == 0;
    }
    
    private void CheckingTheTriangleForReality()
    {
        if (_sideA >= _sideB + _sideC || _sideB >= _sideA + _sideC || _sideC >= _sideB + _sideA)
        {
            throw new ArgumentException("A triangle with such sides does not exist");
        }
    }
}