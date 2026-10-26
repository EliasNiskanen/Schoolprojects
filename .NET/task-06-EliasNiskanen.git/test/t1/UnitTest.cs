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
    public async void Checkpoint01()
    {
        // Arrange
        var univId = 1;
        var expectedCourseIds = new int[] { 10, 11, 12 };

        // Act
        var response = await _client.GetFromJsonAsync<IEnumerable<object>>($"/university/{univId}/courses");

        // Assert
        Assert.NotNull(response);
        var actualIds = response.Select(r => ((JsonElement)r).GetProperty("id").GetInt32());
        Assert.Equal(expectedCourseIds, actualIds);
        int objects = response.Count();
        Random r = new Random();
        JsonElement e = (JsonElement)response.Skip(r.Next(0, objects)).Take(1).FirstOrDefault();
        Assert.NotNull(e.GetProperty("name"));
        Assert.Equal(univId, e.GetProperty("universityId").GetInt32());
    }
}