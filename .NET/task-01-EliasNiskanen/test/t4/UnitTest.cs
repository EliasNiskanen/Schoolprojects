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
    [InlineData(1, -1, "Arguments: 1 -1")]
    [InlineData(5, 8, "Arguments: 5 8")]
    [InlineData(int.MaxValue, 2, "Arguments: 2147483647 2")]
    [InlineData(null, 2, "Arguments: 2")]
    public async void Checkpoint04(int? w, int? h, string expected)
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