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
using AngleSharp.Html.Dom;
using System.Net;

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
    public async void Checkpoint03_CheckFields()
    {
        // Arrange
        var requiredInputs = new List<string>()
        {
            "Make",
            "Model",
            "RAM",
            "PublishDate"
        };

        // Act
        var response = await _client.GetAsync("/phones/add");
        var content = await HtmlHelpers.GetDocumentAsync(response);
        var allInputs = content.QuerySelectorAll("input");
        var dataInputs = allInputs.Where(i => i.GetAttribute("type").ToLower() != "submit" && i.GetAttribute("name") != "__RequestVerificationToken");
        // _testOutputHelper.WriteLine(string.Join("\n", dataInputs.Select(i => i.GetAttribute("type"))));
        // _testOutputHelper.WriteLine(await response.Content.ReadAsStringAsync());

        // Assert
        Assert.True(response.IsSuccessStatusCode);
        Assert.Equal(requiredInputs.Count, dataInputs.Count());
        var dataInputNames = dataInputs.Select(i => i.GetAttribute("name")).ToList();
        Assert.Equal(requiredInputs, dataInputNames);
    }

    [Fact]
    public async void Checkpoint03_Post()
    {
        Random r = new Random();
        // Arrange
        Phone phone = new Phone
        {
            Make = "Tester-" + r.Next(),
            Model = "Automated-" + r.Next(),
            RAM = r.Next(),
            PublishDate = new DateTime(1234, 12, 13)
        };

        // Act
        var responseGet = await _client.GetAsync("/phones/add");
        var content = await HtmlHelpers.GetDocumentAsync(responseGet);

        //_testOutputHelper.WriteLine(await response.Content.ReadAsStringAsync());
        var responsePost = await _client.SendAsync(
                (IHtmlFormElement)content.QuerySelector("form"),
                new Dictionary<string, string>
                {
                    {"Make", phone.Make},
                    {"Model", phone.Model},
                    {"RAM", phone.RAM.ToString()},
                    {"PublishDate", phone.PublishDate.ToString("O")}
                });
        var phonesPage = await responsePost.Content.ReadAsStringAsync();

        // Assert
        Assert.True(responseGet.IsSuccessStatusCode);
        Assert.True(responsePost.IsSuccessStatusCode);
        Assert.True(phonesPage.Contains(phone.Make));
        Assert.True(phonesPage.Contains(phone.Model));
    }
}