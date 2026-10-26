using Microsoft.EntityFrameworkCore;

namespace UnivEnrollerApi.Data;
public class UnivEnrollerContext : DbContext
{
    public UnivEnrollerContext(DbContextOptions<UnivEnrollerContext> options)
           : base(options)
    {
    }

    public DbSet<University> Universities { get; set; } = null!;
    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<Course> Cources { get; set; } = null!;
    public DbSet<Enrollment> Enrollments { get; set; } = null!;
}