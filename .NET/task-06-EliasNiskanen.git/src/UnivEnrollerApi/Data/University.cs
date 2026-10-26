namespace UnivEnrollerApi.Data;
public class University
{
    public int Id { get; set; }
    public string Name { get; set; }

    // Note! other university properties are omitted from this task
    public List<Course> Cources { get; set; }
}