using Microsoft.AspNetCore.Mvc;
using WebApi1.Dtos; 
using WebApi1.Interfaces.Services;


namespace WebApi1.Controllers
{  
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController (IStudentService studentService)
        {
            _studentService = studentService;
        }




        [HttpPost]
        public IActionResult RegisterStudent (CreateStudentRequest request)
        {
            var s = _studentService.AddStudent(request);
            return Ok(s.Message);
        }






        [HttpGet("GetStudentById")]
        public IActionResult   GetStudentById(int id)
        {
            var s = _studentService.GetStudentById(id);
            return Ok(s);
        }



        [HttpPost("UpdateStudent")]
        public IActionResult UpdateStudent (UpdateStudentRequest request,string matricNo)
        {
            var s = _studentService.UpdateStudent(request, matricNo);
            return Ok(s);
        }




        [HttpGet("GetStudentByMatricNo")]
        public IActionResult GetStudentByMatricNo(string matricNo)
        {
            var s = _studentService.GetStudentByMatricNo(matricNo);
            return Ok(s);
        }






         




















    }
}
