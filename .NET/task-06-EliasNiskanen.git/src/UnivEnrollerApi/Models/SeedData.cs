using Microsoft.EntityFrameworkCore;
using UnivEnrollerApi.Data;

namespace UnivEnrollerApi.Models;

    public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new UnivEnrollerContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<UnivEnrollerContext>>()))
        {
            if (context == null)
            {
                throw new ArgumentNullException("Null UnivEnrollerContext");
            }

            context.Database.EnsureCreated();

            // Look for any universities.
            if (context.Universities.Any())
            {
                return;   // DB has been seeded
                // To re-seed the db: delete the existing *.db file and let the app create a new one
            }

            context.Universities.AddRange(
                new University {
                    Id = 1,
                    Name = "Savonia UAS"
                },

                new University {
                    Id = 2,
                    Name = "UEF"
                }
            );

            context.Cources.AddRange(
                new Course {
                    Id = 10,
                    Name = ".NET Programming",
                    UniversityId = 1
                },
                new Course {
                    Id = 11,
                    Name = "Introduction to cloud services",
                    UniversityId = 1
                },
                new Course {
                    Id = 12,
                    Name = "General Engineering",
                    UniversityId = 1
                },
                new Course {
                    Id = 20,
                    Name = "Introduction to AI",
                    UniversityId = 2
                },
                new Course {
                    Id = 21,
                    Name = "Physics 101",
                    UniversityId = 2
                },
                new Course {
                    Id = 22,
                    Name = "Database design",
                    UniversityId = 2
                }
            );

            context.Students.AddRange(
                new Student {
                    Id = 1000,
                    Name = "John Doe"
                },
                new Student {
                    Id = 2000,
                    Name = "Jane Doe"
                },
                new Student {
                    Id = 3000,
                    Name = "Luke Walker"
                },
                new Student {
                    Id = 4000,
                    Name = "Darth Sky"
                }
            );

            context.Enrollments.AddRange(
                new Enrollment {
                    Id = 42,
                    StudentId = 1000,
                    CourseId = 10,                    
                },
                new Enrollment {
                    Id = 43,
                    StudentId = 1000,
                    CourseId = 12,
                    Grade = 3,
                    GradingDate = new DateTime(2021, 12, 10)
                },
                new Enrollment {
                    Id = 44,
                    StudentId = 3000,
                    CourseId = 21,                    
                },
                new Enrollment {
                    Id = 45,
                    StudentId = 3000,
                    CourseId = 10,                    
                },
                new Enrollment {
                    Id = 46,
                    StudentId = 4000,
                    CourseId = 11,                    
                    Grade = 5,
                    GradingDate = new DateTime(2020, 05, 05)
                },
                new Enrollment {
                    Id = 47,
                    StudentId = 3000,
                    CourseId = 22,                    
                }
            );

            context.SaveChanges();
        }
    }
}
