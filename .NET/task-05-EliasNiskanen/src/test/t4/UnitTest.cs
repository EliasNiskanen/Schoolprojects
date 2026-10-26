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
    private readonly PhonesContext _db;

    public UnitTest(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
        _applicationFactory = new WebApplicationFactory<Program>()
                .WithWebHostBuilder(builder =>
                {
                    // ... Configure test services
                });

        _client = _applicationFactory.CreateClient();

        string connectionstring = "Data Source=Phones.db";

        var optionsBuilder = new DbContextOptionsBuilder<PhonesContext>();
        optionsBuilder.UseSqlite(connectionstring);

        _db = new PhonesContext(optionsBuilder.Options);
    }

    [Fact]
    public async void Checkpoint04_CheckFields()
    {
        // Arrange
        var requiredInputs = new List<string>()
        {
            "Id",
            "Make",
            "Model",
            "RAM",
            "PublishDate",
            "Created",
            "Modified"
        };
        var readonlyInputs = new List<string>()
        {
            "Id",
            "Created",
            "Modified"
        };

        // Act
        var response = await _client.GetAsync("/phones/edit/1");
        var content = await HtmlHelpers.GetDocumentAsync(response);
        var allInputs = content.QuerySelectorAll("input");
        var dataInputs = allInputs.Where(i => i.GetAttribute("type").ToLower() != "submit" && i.GetAttribute("name") != "__RequestVerificationToken");

        // _testOutputHelper.WriteLine(await response.Content.ReadAsStringAsync());

        // Assert
        Assert.True(response.IsSuccessStatusCode);
        Assert.Equal(requiredInputs.Count, dataInputs.Count());
        var dataInputNames = dataInputs.Select(i => i.GetAttribute("name")).ToList();
        Assert.Equal(requiredInputs, dataInputNames);
        var readonlyInputNames = content.QuerySelectorAll("[readonly]").Select(i => i.GetAttribute("name")).ToList();
        Assert.Equal(readonlyInputs, readonlyInputNames);
    }

    [Fact]
    public async void Checkpoint04_Post()
    {
        // Arrange
        Random r = new Random();
        int skip = r.Next(0, _db.Phones.Count());
        Phone phone = await _db.Phones.Skip(skip).Take(1).FirstOrDefaultAsync();

        // Act
        var responseGet = await _client.GetAsync("/phones/edit/" + phone.Id.ToString());
        var content = await HtmlHelpers.GetDocumentAsync(responseGet);

        //_testOutputHelper.WriteLine(await response.Content.ReadAsStringAsync());
        phone.Make += r.Next().ToString();
        phone.Model += r.Next().ToString();

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
        // _testOutputHelper.WriteLine(phonesPage);

        // Assert
        Assert.True(responseGet.IsSuccessStatusCode);
        Assert.True(responsePost.IsSuccessStatusCode);
        Assert.True(phonesPage.Contains(phone.Make));
        Assert.True(phonesPage.Contains(phone.Model));
    }
}