using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UnivEnrollerApi.Data;
using UnivEnrollerApi.Data;
using UnivEnrollerApi.Models;

namespace UniversityCourseEnrollments.Controllers
{
    [Route("")]
    [ApiController]
    public class EnrollmentsController : ControllerBase
    {
        private readonly UnivEnrollerContext _context;

        public EnrollmentsController(UnivEnrollerContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Enrollment>>> GetEnrollment()
        {
            return await _context.Enrollments.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Enrollment>> GetEnrollment(int id)
        {
            var enrollment = await _context.Enrollments.FindAsync(id);

            if (enrollment == null)
            {
                return NotFound();
            }

            return enrollment;
        }
        [HttpGet("/university/{universityId}/courses")]
        public async Task<ActionResult<IEnumerable<Course>>> GetCoursesByUniversity(int universityId)
        {
            var courses = await _context.Cources
                .Where(c => c.UniversityId == universityId)
                .Select(c => new
                {
                    c.Id,
                    c.Name,
                    c.UniversityId
                })
                .ToListAsync();

            if (courses == null)
            {
                return NotFound();
            }

            return Ok(courses);
        }
        [HttpGet("/student/{studentId}/courses")]
        public async Task<ActionResult<IEnumerable<Enrollment>>> GetCoursesByStudent(int studentId)
        {
            var enrollments = await _context.Enrollments
                .Include(e => e.Course)
                .Where(e => e.StudentId == studentId)
                .Select(e => new
                {
                    e.Id,
                    e.CourseId,
                    e.Course,
                    e.Grade,
                    e.GradingDate
                })
                .ToListAsync();

            if (enrollments == null)
            {
                return NotFound();
            }

            return Ok(enrollments);
        }
        [HttpPost("/course")]
        public async Task<ActionResult<Course>> PostCourse(Course course)
        {
            _context.Cources.Add(course);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetCourse", new { id = course.Id }, course);
        }
        [HttpGet("/course/{id}")]
        public async Task<ActionResult<Course>> GetCourse(int id)
        {
            var course = await _context.Cources.FindAsync(id);

            if (course == null)
            {
                return NotFound();
            }

            return course;
        }
        [HttpDelete("/student/{studentId}/course/{courseId}")]
        public async Task<ActionResult<Enrollment>> DeleteEnrollment(int StudentId, int CourseId)
        {
            var enrollment = await _context.Enrollments
                .Where(e => e.StudentId == StudentId && e.CourseId == CourseId && e.Grade == null)
                .FirstOrDefaultAsync();

            if (enrollment == null)
            {
                return StatusCode(204);
            }

            _context.Enrollments.Remove(enrollment);
            await _context.SaveChangesAsync();

            return enrollment;
        }
        [HttpPut("grade")]
        public async Task<IActionResult> PutGrade(Enrollment enrollment)
        {
            if (enrollment.Grade < 0 || enrollment.Grade > 5)
            {
                return BadRequest("Invalid grade value. Grade must be an integer in the range [0, 5].");
            }
            int? grade = enrollment.Grade;
            DateTime? createdDate = enrollment.GradingDate;

            enrollment = await _context.Enrollments
           .Where(e => e.StudentId == enrollment.StudentId && e.CourseId == enrollment.CourseId)
           .FirstOrDefaultAsync();

            enrollment.Grade = grade;
            enrollment.GradingDate = createdDate;

            if (enrollment == null)
            {
                return StatusCode(400);
            }

            //enrollment.Grade = grade;
            //enrollment.GradingDate = gradingDate;

            _context.Entry(enrollment).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return StatusCode(204);
        }
    }
}