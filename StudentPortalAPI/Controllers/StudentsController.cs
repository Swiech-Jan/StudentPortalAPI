using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentPortalAPI.DomainModels;
using StudentPortalAPI.Repositories;

namespace StudentPortalAPI.Controllers
{
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly IStudentRepository studentRepository;
        private readonly IMapper mapper;

        public StudentsController(IStudentRepository studentRepository, IMapper mapper)
        {
            this.studentRepository = studentRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("[controller]")]
        public IActionResult GetAllStudents()
        {
           var students = studentRepository.GetStudents();    
           return Ok(mapper.Map<List<Student>>(students));
        }
    }
}
