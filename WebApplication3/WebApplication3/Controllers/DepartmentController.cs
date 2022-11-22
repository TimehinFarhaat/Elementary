using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Entities;
using WebApplication3.Interfaces.Services;


namespace WebApplication3.Controllers
{
    public class DepartmentController:Controller
    {
        private readonly IDepartmentService _service;


        public DepartmentController (IDepartmentService service)
        {
            _service = service;
        }

       

        public IActionResult Index ()
        {
            var teachers = _service.GetDepartment();
            return View(teachers.Data);
        }






        public IActionResult  Create ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create (Department department)
        {
            _service.RegisterDepartment(department);
            return RedirectToAction("Index");
        }


        public IActionResult GetDetails (int id)
        {
            var teacher = _service.GetDepartment(id);
            if (teacher == null)
            {
                return NotFound($"Teacher with id {id} does not exist");
            }

            return View(teacher.Data);
        }



        public IActionResult Edit (int id)
        {
            var teach = _service.GetDepartment(id);
            if (teach == null)
            {
                return NotFound($"Teacher with  id {id} does not exist");
            }
            else
            {
                return View();
            }

        }
        [HttpPost]
        public IActionResult Edit (int id, Department department)
        {
            _service.UpdateDepartment(id, department);
            return RedirectToAction("Index");
        }


        public IActionResult Delete (int id)
        {
            var teach = _service.GetDepartment(id);
            if (teach == null)
            {
                return NotFound($"Teacher with  id {id} does not exist");
            }
            else
            {
                return View();
            }
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed (int id)
        {
            _service.DeleteDepartment(id);
            return RedirectToAction("Index");
        }
    }
}
