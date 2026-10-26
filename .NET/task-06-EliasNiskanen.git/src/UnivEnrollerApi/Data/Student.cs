namespace UnivEnrollerApi.Data;
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }

    // Note! other student properties are omitted from this task
    public List<Enrollment> Enrollments { get; set; }
        
}