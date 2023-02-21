namespace Mindbox.Squares.Library;

public interface IFigureFactory
{
    IFigure CreateObject(params double[] sideValues);
}