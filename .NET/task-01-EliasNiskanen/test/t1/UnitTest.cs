using Xunit;
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
    public async void Checkpoint01()
    {
        ProcessStartInfo psi = new ProcessStartInfo("dotnet", "run --project ../../../../../src/ConsoleApp.csproj");
        psi.CreateNoWindow = true;
        psi.RedirectStandardOutput = true;
        Process p = Process.Start(psi);
        Assert.NotNull(p);
        await p.WaitForExitAsync();
        string pout = await p.StandardOutput.ReadToEndAsync();
        Assert.StartsWith("Hello, .NET!", pout);
        output.WriteLine(pout);
    }
}