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

    [Fact]
    public void Checkpoint03_1()
    {
        // proper class file name
        string path = "../../../../../src/ShapesLibrary/Circle.cs";
        bool exists = File.Exists(path);
        Assert.True(exists);
        FileInfo fi = new FileInfo(path);
        Assert.NotNull(fi);
        Assert.Equal("Circle.cs", fi.Name, false);
    }

    [Fact]
    public void Checkpoint03_2()
    {
        var type = typeof(Circle);
        var method = type.GetMethod("Area");
        Assert.NotNull(method);
        method = type.GetMethod("Circumference");
        Assert.NotNull(method);
        // check return type
        Assert.Equal(typeof(double), method.ReturnType);
    }

    [Fact]
    public void Checkpoint03_3()
    {
        Circle c1 = new Circle();
        Assert.NotNull(c1);
        Assert.Equal(0.0, c1.Area());
        Assert.Equal(0.0, c1.Circumference());
    }
    
    [Fact]
    public void Checkpoint03_4()
    {
        Circle c2 = new Circle(6);
        Assert.NotNull(c2);
        Assert.Equal(113.09733552923255, c2.Area());
        Assert.Equal(37.69911184307752, c2.Circumference());
    }
}