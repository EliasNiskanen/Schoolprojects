using Xunit;
using ShapesLibrary;
using System;
using System.IO;
using System.Diagnostics;
using Xunit.Abstractions;

namespace test;

public class UnitTest
{
    private readonly ITestOutputHelper output;
    public UnitTest(ITestOutputHelper output)
    {
        this.output = output;
    }

    [Theory]
    [InlineData(typeof(Rectangle), 3.0, 8.0, "Rectangle with width 3.00 and height 8.00 has area 24.00 and circumference 22.00")]
    [InlineData(typeof(Circle), 2.0, 2.0, "Circle with radius 2.00 has area 12.57 and circumference 12.57")]
    public async void Checkpoint04(Type type, double w, double h, string expected)
    {
        IShape shape = null;
        if (type ==  typeof(Rectangle))
        {
            shape = new Rectangle(w, h);
            Assert.Equal(expected, shape.ToString());
        }
        else if (type == typeof(Circle))
        {
            shape = new Circle(w);
            Assert.Equal(expected, shape.ToString());
        }
    }
}