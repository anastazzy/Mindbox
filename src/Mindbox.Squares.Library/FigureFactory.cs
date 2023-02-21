namespace Mindbox.Squares.Library;

public class FigureFactory : IFigureFactory
{
    private const double MinValue = 0;
    
    public IFigure CreateObject(params double[] sideValues)
    {
        if (sideValues.Any(x => x < MinValue))
        {
            throw new ArgumentException( "The entered values should not be negative." );
        }
        
        var count = sideValues.Length;
        if (count is not (1 or 3))
        {
            throw new ArgumentException("A figure with so many parameters is not supported.");
        }
        
        if (count == 1)
        {
            return new Circle(sideValues[0]);
        }
        
        return new Triangle(sideValues[0], sideValues[1], sideValues[2]);
    }
}