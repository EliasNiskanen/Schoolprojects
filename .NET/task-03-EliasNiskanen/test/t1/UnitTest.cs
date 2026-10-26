using Xunit;
using System;
using System.IO;
using System.Diagnostics;
using Xunit.Abstractions;
using EFApp.Data;

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
        // check data folder
        string path = "../../../../../src/EFApp/Data";
        bool exists = Directory.Exists(path);
        Assert.True(exists);
        FileInfo fi = new FileInfo($"{path}/Product.cs");
        Assert.NotNull(fi);
        Assert.True(fi.Exists);

        Customer c = new Customer();
        Assert.NotNull(c);

        AdventureWorksLTContext db = new AdventureWorksLTContext();
        Assert.NotNull(db);
    }
}