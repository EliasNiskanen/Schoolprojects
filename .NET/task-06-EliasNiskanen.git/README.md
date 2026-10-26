# Task 06: Web API

<img alt="points bar" align="right" height="36" src="../../blob/badges/.github/badges/points-bar.svg" />

![GitHub Classroom Workflow](../../workflows/GitHub%20Classroom%20Workflow/badge.svg?branch=main)

***

## Student info

> Write your name, your estimation on how many points you will get and an estimate on how long it took to make the answer

- Student name:Elias Niskanen	
- Estimated points: 4
- Estimated time (hours): 10

***

## Purpose of this task

The purposes of this task are:

- to learn to create an ASP.NET Web api
- to learn to handle routing in web api
- to learn to use models and data with web api
- to learn to understand how JSON and serialization works

## Material for the task

> **Following material will help with the task.**

It is recommended that you will check the material before begin coding.

1. [Create web APIs with ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-6.0)
2. [Tutorial: Create a web API with ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0)
3. [Validation attributes](https://docs.microsoft.com/en-us/aspnet/core/mvc/models/validation?view=aspnetcore-6.0#validation-attributes)

## The Task

Create an ASP.NET Web API to handle university course enrollments. Implement basic CRUD (Create, Read, Update and Delete) endpoints to handle the data. Use default ASP.NET conventions for the implementation and use web api with controllers for the endpoints. The data entities (classes) and context are given and properly configured in Program.cs file. Use the given data to implement the endpoints.

### Evaluation points

1. Endpoint GET (/university/[id]/courses) returns a list of cources in the selected univ. The returned data must contain the course id, course name and university id and be an array of objects containing the required data as (comments can be omitted):

    ```json
    {
        "id": 1, // value for course Id
        "name": "Course name",
        "universityId": 3 // value for university Id
    }
    ```

2. Endpoint GET (/student/[id]/courses) returns a list of courses that the student has enrolled and for completed courses the grades are returned along with the grading date. The returned data must contain enrollement id, course id, course name, grade and grading date and be an array of objects containing the required data as (comments can be omitted):

    ```json
    {
        "id": 1, // value for enrollment Id
        "courseId: 3, // value for course Id
        "course": "Course name",
        "grade": 3, // value for grade if any
        "gradingDate": "2022-05-06" // value for grading date if any (must be deserializable to DateTime)
    }
    ```

3. Endpoint POST (/course) creates a new course to a univ. University id is part or the POST payload with course's name. The endpoint must return Location header with working URI to the created resource (the course) which is tested with HTTP GET request. The GET request to the URI in the Location header must return the created course's data in a similar object as described in step 1 above. The endpoint must accept following data (comments can be omitted):

    ```json
    {
        "universityId": 1, // value for university Id
        "name: "course name here"
    }
    ```

4. Endpoint DELETE (/student/[id]/course/[id]) deletes the student's enrollment for the course if the course is not graded. Request to delete a graded course must not change any data.
5. Endpoint PUT (/grade) sets a grade to the student for a course. Student id, course id, grade and grading date is in PUT body. Note that the grade can only be integer value in range [0, 5] (i.e. only values 0, 1, 2, 3, 4 or 5 are allowed). The endpoint must return 400 Bad Request if submitted data is not valid. The endpoint must accept following data (comments can be omitted):

    ```json
    {
        "studentId": 1, // value for student Id
        "courseId: 3, // value for course Id
        "grade": 3, // value for grade
        "gradingDate": "2022-05-06" // value for grading date (must be deserializable to DateTime)
    }
    ```

> Note! Read the task description and the evaluation points to get the task's specification (what is required to make the app complete).

## Task evaluation

Evaluation points for the task are described above. An evaluation point either works or it does not work there is no "it kind of works" step inbetween. Be sure to test your work. All working evaluation points are added to the task total and will count towards the course total. The task is worth five (5) points. Each evaluation point is checked individually and each will provide one (1) point so there is five checkpoints. Checkpoints are designed so that they may require additional code, that is not checked or tested, to function correctly.

## DevOps

There is a DevOps pipeline added to this task. The pipeline will build the solution and run automated tests on it. The pipeline triggers when a commit is pushed to GitHub on main branch. So remember to `git commit` `git push` when you are ready with the task. The automation uses GitHub Actions and some task runners. The automation is in folder named .github.

> **DO NOT modify the contents of .github or test folders.**
