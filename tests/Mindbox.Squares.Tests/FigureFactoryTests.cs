using System;
using Xunit;

namespace Mindbox.Squares.Tests;

public class FigureFactoryTests : WithLibraryTest
{
    [Fact]
    public void CreateObject_OneNegativeParameter_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => Factory.CreateObject(-12));
    }
    
    [Fact]
    public void CreateObject_OneOfSeveralNegativeParameters_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => Factory.CreateObject(1, 3, -12));
    }
    
    [Fact]
    public void CreateObject_WrongNumberOfParameters_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => Factory.CreateObject(1, 3, 3, 42));
    }
}