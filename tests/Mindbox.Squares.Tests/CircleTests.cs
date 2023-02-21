using System;
using Xunit;

namespace Mindbox.Squares.Tests;

public class CircleTests : WithLibraryTest
{
    [Fact]
    public void GetSquare_RadiusNotNull_ReturnSquare()
    {
        var figure = Factory.CreateObject(12);
        Assert.Equal(904.78, Math.Round(figure.GetSquare(), 2));
    }
}