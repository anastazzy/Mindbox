using System;
using Mindbox.Squares.Library;
using Xunit;

namespace Mindbox.Squares.Tests;

public class TriangleTests : WithLibraryTest
{
    [Fact]
    public void CreateNewTriangle_TriangleCanNotExist_ThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => Factory.CreateObject(1, 2, 3));
    }
    
    [Fact]
    public void GetSquare_TriangleIsNotRight_ReturnSquare()
    {
        var figure = Factory.CreateObject(10, 20, 13);
        Assert.Equal(56.15 , Math.Round(figure.GetSquare(), 2));
        
        var triangle = figure as ITriangle;
        Assert.False(triangle?.IsRightTriangle);
    }
    
    [Fact]
    public void GetSquare_TriangleIsRight_ReturnSquare()
    {
        var figure = Factory.CreateObject(3, 4, 5);
        Assert.Equal(6, Math.Round(figure.GetSquare(), 2));
        
        var triangle = figure as ITriangle;
        Assert.True(triangle?.IsRightTriangle);
    }
}