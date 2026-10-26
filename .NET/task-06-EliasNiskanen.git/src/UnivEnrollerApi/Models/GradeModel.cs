using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UnivEnrollerApi.Models;

public class GradeModel
{
    public int StudentId { get; set; }
    public int CourseId { get; set; }

    [Range(0, 5)]
    public int Grade { get; set; }
    public DateTime GradingDate { get; set; }
}
