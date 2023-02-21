using Mindbox.Squares.Library;

namespace Mindbox.Squares.Tests;

public class WithLibraryTest
{
    public FigureFactory Factory { get; set; }

    public WithLibraryTest()
    {
        Factory = new FigureFactory();
    }

}