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

    [Theory]
    [InlineData(4, 6, 24)]
    [InlineData(1, 1, 1)]
    [InlineData(-1, 1, null)]
    [InlineData(1, -1, null)]
    [InlineData(0, 1, 0)]
    [InlineData(int.MaxValue, 10, null)]
    public void Checkpoint03(int w, int h, int? expected)
    {
        Calculator calculator = new Calculator();
        int? actual = calculator.CalculateArea(w, h);
        Assert.Equal(expected, actual);
    }
}