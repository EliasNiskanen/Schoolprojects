# Task 02: Class library

<img alt="points bar" align="right" height="36" src="../../blob/badges/.github/badges/points-bar.svg" />

![GitHub Classroom Workflow](../../workflows/GitHub%20Classroom%20Workflow/badge.svg?branch=main)

***

## Student info

> Write your name, your estimation on how many points you will get and an estimate on how long it took to make the answer

- Student name: Elias Niskanen      
- Estimated points: 5
- Estimated time (hours): 8h

***

## Purpose of this task

The purposes of this task are:

- to learn to create a class library
- to learn to use class library's classes in another project

## Material for the task

> **Following material will help with the task.**

It is recommended that you will check the material before begin coding.

1. [.NET class libraries](https://docs.microsoft.com/en-us/dotnet/standard/class-libraries)
2. [14.6.5 Override methods](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/classes#1465-override-methods)
3. [String.Format Method](https://docs.microsoft.com/en-us/dotnet/api/system.string.format?view=net-6.0)

## The Task

Create an interface and two classes that implement the interface. Override ToString() method on the two classes. Use the classes in a console app.

### Evaluation points

1. Create an interface IShape which defines methods double Area() and double Circumference(). The interface must be in the class library.

2. Create a class Rectangle which implements the IShape interface. Rectangle has two constructors one that does not take parameters and one that takes parameters width and height (double). Implement interface methods. The class must be in the class library.

3. Create a class Circle which implements the IShape interface. Circle has two constructors one that does not take parameters and one that takes one parameter radius (double). Implement interface methods. *Hint use System.Math.PI*. The class must be in the class library.

4. Override ToString() methods on both classes: Rectancle will return a string like "Rectangle with width X and height Y has area A and circumference C". Circle will return a string like "Circle with radius X has area A and circumference C". In samples X, Y, A and C are placeholders for the actual values from the class instance. Format the strings so that values are written with two decimals like 3.14 or 5.00. Notice the decimal separator and use proper string format methods to produce the desired output.

5. Use the class library on a console app. The console app needs a reference to the class library project. In console app instantiate both classes with values 4 and 5 for rectangle and value 3 for circle and write the ToString() methods output to console  

> Note! Read the task description and the evaluation points to get the task's specification (what is required to make the app complete).

## Task evaluation

Evaluation points for the task are described above. An evaluation point either works or it does not work there is no "it kind of works" step inbetween. Be sure to test your work. All working evaluation points are added to the task total and will count towards the course total. The task is worth five (5) points. Each evaluation point is checked individually and each will provide one (1) point so there is five checkpoints. Checkpoints are designed so that they may require additional code, that is not checked or tested, to function correctly.

## DevOps

There is a DevOps pipeline added to this task. The pipeline will build the solution and run automated tests on it. The pipeline triggers when a commit is pushed to GitHub on main branch. So remember to `git commit` `git push` when you are ready with the task. The automation uses GitHub Actions and some task runners. The automation is in folder named .github.

> **DO NOT modify the contents of .github or test folders.**
