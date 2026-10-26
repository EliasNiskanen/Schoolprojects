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
using EFApp.Models;

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
    [InlineData(29485, "Main Office", true, "Catherine", "Abel", "57251 Serene Blvd", "Van Nuys")]
    [InlineData(29494, "Shipping", true, "Samuel", "Agcaoili", null, null)]
    [InlineData(30119, "Shipping", false, null, null, null, null)]
    public async Task Checkpoint05(int cid, string type, bool notNull, string fn, string ln, string a, string c)
    {
        CustomerInfo actual = await db.GetCustomerInfoAsync(cid, type);
        Assert.Equal(notNull, null != actual);
        Assert.Equal(fn, actual?.Firstname);
        Assert.Equal(ln, actual?.Lastname);
        Assert.Equal(a, actual?.AddressLine1);
        Assert.Equal(c, actual?.City);
    }
}