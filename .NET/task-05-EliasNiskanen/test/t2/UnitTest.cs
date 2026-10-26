using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using MVCPhones;
using MVCPhones.Data;
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
    public async void Checkpoint02_AddLink()
    {
        // Arrange

        // Act
        var response = await _client.GetAsync("/phones");
        var content = await HtmlHelpers.GetDocumentAsync(response);
        var links = content.QuerySelectorAll("a");
        //_testOutputHelper.WriteLine(await response.Content.ReadAsStringAsync());

        // Assert
        Assert.True(response.IsSuccessStatusCode);
        Assert.Contains(links, a => a.GetAttribute("href").ToLower() == "/phones/add");
    }

    [Fact]
    public async void Checkpoint02_Content()
    {
        // Arrange
        int index = 0;
        var phones = new List<Phone>() {  
            new Phone
            {
                Make = "Apple",
                Model = "iPhone 13"
            },
            new Phone
            {
                Make = "Apple",
                Model = "iPhone 13 mini"
            },
            new Phone
            {
                Make = "Apple",
                Model = "iPhone X"
            },
            new Phone
            {
                Make = "Demo",
                Model = "One"
            },
            new Phone
            {
                Make = "Demo",
                Model = "Two"
            },
            new Phone
            {
                Make = "Huawei",
                Model = "Mate 2"
            },
            new Phone
            {
                Make = "Motorola",
                Model = "X"
            },
            new Phone
            {
                Make = "Nokia",
                Model = "8"
            },
            new Phone
            {
                Make = "Samsung",
                Model = "Galaxy S22"
            }
        };

        // Act
        var response = await _client.GetAsync("/phones");
        var content = await HtmlHelpers.GetDocumentAsync(response);
        var ul = content.QuerySelector("ul.phones");
        var lis = ul.QuerySelectorAll("li");
        // _testOutputHelper.WriteLine(await response.Content.ReadAsStringAsync());

        // Assert
        Assert.True(response.IsSuccessStatusCode);
        Assert.Equal(phones.Count, lis.Count());
        foreach (var item in phones)
        {
            var li = lis[index++];
            var text = li.TextContent;
            Assert.Contains(item.Make, text);
            Assert.Contains(item.Model, text);
            Assert.Equal(2, li.QuerySelectorAll("a").Count());
        }
    }
}