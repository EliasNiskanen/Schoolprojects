using Xunit;
using ConsoleApp;
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
        string path = "../../../../../src/Calculator.cs";
        bool exists = File.Exists(path);
        Assert.True(exists);
        FileInfo fi = new FileInfo(path);
        Assert.NotNull(fi);
        Assert.Equal("Calculator.cs", fi.Name, false);
    }

    [Fact]
    public void Checkpoint02_2()
    {
        var type = typeof(Calculator);
        var method = type.GetMethod("CalculateArea");
        Assert.NotNull(method);
        // check return type
        Assert.Equal(typeof(int?), method.ReturnType);
    }
}