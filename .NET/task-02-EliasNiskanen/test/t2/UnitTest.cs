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
    public void Checkpoint02_1()
    {
        // proper class file name
        string path = "../../../../../src/ShapesLibrary/Rectangle.cs";
        bool exists = File.Exists(path);
        Assert.True(exists);
        FileInfo fi = new FileInfo(path);
        Assert.NotNull(fi);
        Assert.Equal("Rectangle.cs", fi.Name, false);
    }

    [Fact]
    public void Checkpoint02_2()
    {
        var type = typeof(Rectangle);
        var method = type.GetMethod("Area");
        Assert.NotNull(method);
        method = type.GetMethod("Circumference");
        Assert.NotNull(method);
        // check return type
        Assert.Equal(typeof(double), method.ReturnType);
    }

    [Fact]
    public void Checkpoint02_3()
    {
        Rectangle r1 = new Rectangle();
        Assert.NotNull(r1);
        Assert.Equal(0.0, r1.Area());
        Assert.Equal(0.0, r1.Circumference());
    }

    [Fact]
    public void Checkpoint02_4()
    {
        Rectangle r2 = new Rectangle(6, 8);
        Assert.NotNull(r2);
        Assert.Equal(48.0, r2.Area());
        Assert.Equal(28.0, r2.Circumference());
    }
}