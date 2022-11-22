using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using WebApplication3.Entities;
using WebApplication3.Implementations.Services;
using WebApplication3.Interfaces.Services;


namespace WebApplication3.Controllers
{
    public class StudentController: Controller
    {
        private readonly IStudentService _service;
        private readonly IDepartmentService _departmentService;
        

        public StudentController (IStudentService service,IDepartmentService departmentService)
        {
            _service = service;
            _departmentService = departmentService;
        }

    

        public IActionResult Index ()
        {
            var teachers = _service.GetTeachers();
            return View(teachers.Data);
        }




        public IActionResult Create()
        {
            var departments = _departmentService.GetDepartment();
            ViewData["Departments"] = new SelectList(departments.Data, "DepartmentId", "DepartmentName");
            return View();
        }
        [HttpPost]
        public IActionResult Create (Student teacher)
        {
            _service.RegisterTeacher(teacher);
            return RedirectToAction("Index");
        }

        public IActionResult GetDetails (int id)
        {
            var teacher = _service.GetTeacher(id);
            if (teacher == null)
            { 
                return NotFound($"Teacher with id {id} does not exist");
            }

            return View(teacher.Data);
        }



        public IActionResult Edit (int id)
        {
            var teach = _service.GetTeacher(id);
            if (teach == null)
            {
                return NotFound($"Teacher with  id {id} does not exist");
            }
            else
            {
                var departments = _departmentService.GetDepartment();
                ViewData["Departments"] = new SelectList(departments.Data, "DepartmentId", "DepartmentName");
                return View(teach.Message);
            }

        }
        [HttpPost]
        public IActionResult Edit (int id,Student teacher)
        {
            _service.UpdateTeacher(id, teacher);
            return RedirectToAction("Index");
        }


        public IActionResult Delete (int id)
        {
            var teach = _service.GetTeacher(id);
            if (teach == null)
            {
                return NotFound($"Teacher with  id {id} does not exist");
            }
            else
            {
                return View(teach.Message);
            }
        }                                                                                                                                             
        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed (int id)
        {
            _service.DeleteTeacher(id);
            return RedirectToAction("Index");
        }


    }
}
