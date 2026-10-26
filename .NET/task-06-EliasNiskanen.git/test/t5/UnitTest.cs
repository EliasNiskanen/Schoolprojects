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
    public async void Checkpoint05_Success()
    {
        // Arrange
        int studentId = 3000;
        int courseId = 10;
        int gradeValue = 3;
        DateTime gradingDate = DateTime.Now;
        var grade = new JsonObject();
        grade.Add("studentId", studentId);
        grade.Add("courseId", courseId);
        grade.Add("grade", gradeValue);
        grade.Add("gradingDate", gradingDate);

        // Act
        var response = await _client.PutAsJsonAsync($"/grade", grade);

        // Assert
        Assert.NotNull(response);
        Assert.True(response.IsSuccessStatusCode);

        // Act 2
        var responseGet = await _client.GetFromJsonAsync<IEnumerable<object>>($"/student/{studentId}/courses");
        Assert.NotNull(responseGet);
        var e = (JsonElement)responseGet.FirstOrDefault(re => ((JsonElement)re).GetProperty("courseId").GetInt32() == courseId);
        Assert.NotNull(e);
        Assert.Equal(gradeValue, e.GetProperty("grade").GetInt32());
        Assert.Equal(gradingDate.Date, e.GetProperty("gradingDate").GetDateTime().Date);
    }

    [Fact]
    public async void Checkpoint05_Fail()
    {
        // Arrange
        int studentId = 3000;
        int courseId = 22;
        int gradeValue = 6;
        DateTime gradingDate = DateTime.Now;
        var grade = new JsonObject();
        grade.Add("studentId", studentId);
        grade.Add("courseId", courseId);
        grade.Add("grade", gradeValue);
        grade.Add("gradingDate", gradingDate);

        // Act
        var response = await _client.PutAsJsonAsync($"/grade", grade);

        // Assert
        Assert.NotNull(response);
        Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode);

        // Act 2
        var responseGet = await _client.GetFromJsonAsync<IEnumerable<object>>($"/student/{studentId}/courses");
        var actualCourseIds = responseGet.Select(r => ((JsonElement)r).GetProperty("courseId").GetInt32());
        _testOutputHelper.WriteLine(string.Join(", ", actualCourseIds));
        Assert.NotNull(responseGet);
        var e = (JsonElement)responseGet.FirstOrDefault(re => ((JsonElement)re).GetProperty("courseId").GetInt32() == courseId);
        Assert.NotNull(e);
        bool hasProp = e.TryGetProperty("grade", out JsonElement gradeProp);
        if (hasProp)
        {
            Assert.Equal(JsonValueKind.Null, gradeProp.ValueKind);
        }
        hasProp = e.TryGetProperty("gradingDate", out JsonElement gradingDateProp);
        if (hasProp)
        {
            Assert.Equal(JsonValueKind.Null, gradingDateProp.ValueKind);
        }
    }
}