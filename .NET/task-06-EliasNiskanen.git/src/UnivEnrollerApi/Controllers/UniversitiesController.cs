using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnivEnrollerApi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace UnivEnrollerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniversitiesController : ControllerBase
    {
        private readonly UnivEnrollerContext _context;


        public UniversitiesController(UnivEnrollerContext context) 
        { 
            this._context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var courses = await _context.Cources.ToListAsync();
            return Ok(courses);
        }

    }
}
