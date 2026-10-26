using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using UnivEnrollerApi.Data;
using UnivEnrollerApi.Models;
using Microsoft.Extensions.DependencyInjection;
using Test.Helpers;
using Xunit;
using Xunit.Abstractions;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace test;

public class UnitTest
{
    private readonly ITestOutputHelper _testOutputHelper;
    private readonly HttpClient _client;
    private readonly WebApplicationFactory<Program> _applicationFactory;

    private readonly UnivEnrollerContext _db;

    public UnitTest(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
        _applicationFactory = new WebApplicationFactory<Program>()
                .WithWebHostBuilder(builder =>
                {
                    // ... Configure test services
                });

        _client = _applicationFactory.CreateClient();

        string connectionstring = "Data Source=Courses.db";

        var optionsBuilder = new DbContextOptionsBuilder<UnivEnrollerContext>();
        optionsBuilder.UseSqlite(connectionstring);

        _db = new UnivEnrollerContext(optionsBuilder.Options);
    }

    [Fact]
    public async void Checkpoint03()
    {
        // Arrange
        int univId = 1;
        string name = "newly created test course";
        var course = new JsonObject();
        course.Add("universityId", univId);
        course.Add("name", name);

        // Act
        var response = await _client.PostAsJsonAsync($"/course", course);

        // Assert
        Assert.NotNull(response);
        Assert.True(response.IsSuccessStatusCode);
        Assert.NotNull(response.Headers.Location);
        var location = response.Headers.Location;
        
        // Act 2
        var responseGet = await _client.GetFromJsonAsync<object>(location);
        Assert.NotNull(responseGet);

        JsonElement e = (JsonElement)responseGet;
        Assert.NotNull(e.GetProperty("id"));
        Assert.Equal(name, e.GetProperty("name").GetString());
        Assert.Equal(univId, e.GetProperty("universityId").GetInt32());
    }
}