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
    [InlineData(1, -1, "Area of 1 and -1 is ")]
    [InlineData(5, 8, "Area of 5 and 8 is 40")]
    [InlineData(int.MaxValue, 2, "Area of 2147483647 and 2 is ")]
    [InlineData(null, 2, "Area of 2 and 0 is 0")]
    public async void Checkpoint05(int? w, int? h, string expected)
    {
        ProcessStartInfo psi = new ProcessStartInfo("dotnet", $"run --project ../../../../../src/ConsoleApp.csproj {w} {h}");
        psi.CreateNoWindow = true;
        psi.RedirectStandardOutput = true;
        Process p = Process.Start(psi);
        Assert.NotNull(p);
        await p.WaitForExitAsync();
        string pout = await p.StandardOutput.ReadToEndAsync();
        Assert.Contains(expected, pout);
        output.WriteLine(pout);
    }
}