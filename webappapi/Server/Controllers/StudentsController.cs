// Controllers/StudentsController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webappapi;
using webappapi.Server.Data;
using webappapi.Shared;

namespace WebApi.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StudentsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            return await _context.Students.Include(s => s.Course).ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Student>> PostStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudent", new { id = student.Id }, student);
        }

        
    }
}
