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

    [Theory]
    [InlineData("Toronto", 3, new int[] { 447, 538, 480 })]
    [InlineData("London", 6, new int[] { 671, 663, 638, 666, 665, 648 })]
    public async Task Checkpoint03(string city, int top, int[] expected)
    {
        List<Address> actual = await db.AddressesInACityAsync(city, top);
        Assert.Equal(actual.Count, top);
        Assert.Equal(actual.Select(a => a.AddressId), expected);
    }
}