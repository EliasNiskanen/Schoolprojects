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
    public async void Checkpoint05_1()
    {
        string path = "../../../../../src/ConsoleApp/ConsoleApp.csproj";
        bool exists = File.Exists(path);
        Assert.True(exists);
        string fileContent = File.ReadAllText(path);
        Assert.Contains("<ProjectReference Include=\"..\\ShapesLibrary\\ShapesLibrary.csproj\" />", fileContent);
    }

    [Fact]
    public async void Checkpoint05_2()
    {
        ProcessStartInfo psi = null;
        if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform.Windows))
        {
            psi = new ProcessStartInfo("dotnet", $"run --project ..\\..\\..\\..\\..\\src\\ConsoleApp\\ConsoleApp.csproj");
        }
        else
        {
            psi = new ProcessStartInfo("dotnet", $"run --project ../../../../../src/ConsoleApp/ConsoleApp.csproj");
        }
         
        psi.CreateNoWindow = true;
        psi.RedirectStandardOutput = true;
        Process p = Process.Start(psi);
        Assert.NotNull(p);
        await p.WaitForExitAsync();
        string pout = await p.StandardOutput.ReadToEndAsync();
        Assert.Contains("Rectangle with width 4.00 and height 5.00 has area 20.00 and circumference 18.00", pout);
        Assert.Contains("Circle with radius 3.00 has area 28.27 and circumference 18.85", pout);
        output.WriteLine(pout);
    }
}