using Microsoft.AspNetCore.Mvc;
using StudentPortalAPI.Repositories;

namespace StudentPortalAPI.Controllers
{
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly IStudentRepository studentRepository;

        public StudentsController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        [HttpGet]
        [Route("[controller]")]
        public IActionResult GetAllStudents()
        {
           return Ok(studentRepository.GetStudents());
        }
    }
}
