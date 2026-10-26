using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using RazorPhones;
using RazorPhones.Data;
using Test.Helpers;
using Xunit;
using Xunit.Abstractions;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;

namespace test;

public class UnitTest
{
    private readonly ITestOutputHelper _testOutputHelper;
    private readonly HttpClient _client;
    private readonly WebApplicationFactory<Program> _applicationFactory;

    public UnitTest(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
        _applicationFactory = new WebApplicationFactory<Program>()
                .WithWebHostBuilder(builder =>
                {
                    // ... Configure test services
                });

        _client = _applicationFactory.CreateClient();
    }

    [Fact]
    public async void Checkpoint01_H1()
    {
        // Arrange

        // Act
        var response = await _client.GetAsync("/");
        var content = await HtmlHelpers.GetDocumentAsync(response);
        var h1 = content.QuerySelector("h1");

        // Assert
        Assert.True(response.IsSuccessStatusCode);
        Assert.Contains("Welcome to the Phone database in Razor Pages", h1.TextContent);
    }

    [Fact]
    public async void Checkpoint01_Top3()
    {
        // Arrange
        int index = 0;
        var ids = new List<string>() { "6", "5", "4" };

        // Act
        var response = await _client.GetAsync("/");
        var content = await HtmlHelpers.GetDocumentAsync(response);
        var tableRows = content.QuerySelectorAll("tr");

        // Assert
        Assert.True(response.IsSuccessStatusCode);
        Assert.Equal(4, tableRows.Count());
        //_testOutputHelper.WriteLine(await response.Content.ReadAsStringAsync());
        Assert.Equal(ids, tableRows.TakeLast(3).Select(t => t.FirstElementChild.TextContent)); 
    }
}