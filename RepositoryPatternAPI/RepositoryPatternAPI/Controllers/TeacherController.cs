using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepositoryPatternAPI.DTOs;
using RepositoryPatternAPI.Interfaces.Services;


namespace RepositoryPatternAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherSrervice _teacherService;


        public TeacherController(ITeacherSrervice teacherService)
        {
            _teacherService = teacherService;
        }


        [HttpPost]
        public IActionResult RegisterTeacher(CreateTeacherRequest request)
        {
           var s= _teacherService.RegisterTeacher(request);
            return Ok(request);
        }



        [HttpGet]
        public IActionResult GetTeacher (int id)
        {
            if (id==0)
            {
                return BadRequest();
            }

            var teacher = _teacherService.GetTeacher(id);
            if (!teacher.Status )
            {
                return NotFound(teacher.Message);
            }

            return Ok(teacher);
        }


    }
}
