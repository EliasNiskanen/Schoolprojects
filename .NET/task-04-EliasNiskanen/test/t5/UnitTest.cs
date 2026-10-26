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
    public async void Checkpoint05_CheckFields()
    {
        // Arrange
        Random r = new Random();
        int skip = r.Next(0, _db.Phones.Count());
        Phone phone = await _db.Phones.Skip(skip).Take(1).FirstOrDefaultAsync();

        // Act
        var response = await _client.GetAsync("/phones/delete/" + phone.Id.ToString());
        var content = await HtmlHelpers.GetDocumentAsync(response);
        var submit = content.QuerySelector("input[type='submit']");


        var deletePage = await response.Content.ReadAsStringAsync();

        // _testOutputHelper.WriteLine(deletePage);

        // Assert
        Assert.True(response.IsSuccessStatusCode);
        Assert.Contains(phone.Make, deletePage);
        Assert.Contains(phone.Model, deletePage);
        Assert.NotNull(submit);
    }

    [Fact]
    public async void Checkpoint05_Post()
    {
        // Arrange
        Random r = new Random();
        int skip = r.Next(0, _db.Phones.Count());
        Phone phone = await _db.Phones.Skip(skip).Take(1).FirstOrDefaultAsync();

        // Act
        var responseGet = await _client.GetAsync("/phones/delete/" + phone.Id.ToString());
        var content = await HtmlHelpers.GetDocumentAsync(responseGet);

        //_testOutputHelper.WriteLine(await response.Content.ReadAsStringAsync());

        var responsePost = await _client.SendAsync(
                (IHtmlFormElement)content.QuerySelector("form"),
                new Dictionary<string, string>()
                );

        var phonesPage = await responsePost.Content.ReadAsStringAsync();
        // _testOutputHelper.WriteLine(phonesPage);
        // _testOutputHelper.WriteLine($"Should be deleted: {phone.Make} - {phone.Model}");

        // Assert
        Assert.True(responseGet.IsSuccessStatusCode);
        Assert.True(responsePost.IsSuccessStatusCode);
        Assert.DoesNotContain($"phones/edit/{phone.Id}", phonesPage, StringComparison.InvariantCultureIgnoreCase);
    }
}