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
    public async void Checkpoint01_1()
    {
        // proper class file name
        string path = "../../../../../src/ShapesLibrary/IShape.cs";
        bool exists = File.Exists(path);
        Assert.True(exists);
        FileInfo fi = new FileInfo(path);
        Assert.NotNull(fi);
        Assert.Equal("IShape.cs", fi.Name, false);
    }

    [Fact]
    public async void Checkpoint01_2()
    {
        var type = typeof(IShape);
        var method = type.GetMethod("Area");
        Assert.NotNull(method);
        method = type.GetMethod("Circumference");
        Assert.NotNull(method);
        // check return type
        Assert.Equal(typeof(double), method.ReturnType);
    }
}