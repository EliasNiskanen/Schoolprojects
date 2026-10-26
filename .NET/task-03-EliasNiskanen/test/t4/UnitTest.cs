using Xunit;
using System;
using System.IO;
using System.Diagnostics;
using Xunit.Abstractions;
using EFApp.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace test;

public class UnitTest
{
    private readonly ITestOutputHelper output;
    private readonly AdventureWorksLTContext db;

    public UnitTest(ITestOutputHelper output)
    {
        this.output = output;

        string connectionstring = "Server=tcp:sav-mik-devsql.database.windows.net,1433;Initial Catalog=AdventureWorksLT;Persist Security Info=False;User ID=ets730021s;Password=qMA9m7b4ZGfEgWsM;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        var optionsBuilder = new DbContextOptionsBuilder<AdventureWorksLTContext>();
        optionsBuilder.UseSqlServer(connectionstring);

        db = new AdventureWorksLTContext(optionsBuilder.Options);

    }

    [Fact]
    public async Task Checkpoint04()
    {
        List<string> actual = await db.ProductCategoryListAsync();
        // output.WriteLine(string.Join("\n", actual));
        Assert.Equal(41, actual.Count);
        Assert.Equal("--3: Clothing--", actual[19]);
        Assert.Equal("13: Derailleurs", actual[10]);
    }
}