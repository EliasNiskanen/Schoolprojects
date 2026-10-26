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

    [Theory]
    [InlineData(4000, 11, new int[] { 11 })]
    [InlineData(3000, 10, new int[] { 21, 22 })]
    public async void Checkpoint04(int studentId, int courseId, int[] expectedCourseIdsAfterDelete)
    {
        // Arrange

        // Act
        var response = await _client.DeleteAsync($"/student/{studentId}/course/{courseId}");

        // Assert
        Assert.NotNull(response);
        Assert.True(response.IsSuccessStatusCode);

        // Act 2
        var responseGet = await _client.GetFromJsonAsync<IEnumerable<object>>($"/student/{studentId}/courses");
        Assert.NotNull(responseGet);
        var actualCourseIds = responseGet.Select(r => ((JsonElement)r).GetProperty("courseId").GetInt32());
        Assert.Equal(expectedCourseIdsAfterDelete, actualCourseIds);
    }
}