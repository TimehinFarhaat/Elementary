using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TwoEntites.Entities;
using TwoEntites.Implementations.Services;
using TwoEntites.Interfaces.Services;


namespace TwoEntites.Controllers
{
    public class DepartmentController:Controller
    {

        private readonly IDepartmentService _departmentService;


        public DepartmentController (IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }


        public IActionResult Index ()
        {
           var t= _departmentService.GetDepartment();
            return View(t);
        }


        public IActionResult AddDepartment ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDepartment (Department department)
        {
            _departmentService.RegisterDepartment(department);
            return RedirectToAction("Index");
        }



        public IActionResult UpdateDepartment (int id)
        {
            var teach = _departmentService.GetDepartment(id);
            if (teach == null)
            {
                return NotFound($"Department with  id {id} does not exist");
            }
            else
            {
                return View(teach);
            }
        }
        [HttpPost]
        public IActionResult UpdateDepartment (int id,Department department)
        {
            _departmentService.UpdateDepartment(id, department);
            return RedirectToAction("Index");
        }


        public IActionResult Details(int id)
        {
            var teach = _departmentService.GetDepartment(id);
            if (teach == null)
            {
                return NotFound($"Department with  id {id} does not exist");
            }
            else
            {
                return View(teach);
            }
        }


        public IActionResult Delete (int id)
        {
            var teach = _departmentService.GetDepartment(id);
            if (teach == null)
            {
                return NotFound($" with  id {id} does not exist");
            }
            else
            {
                return View(teach);
            }
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed (int id)
        {
            _departmentService.DeleteDepartment(id);
            return RedirectToAction("Index");
        }













    }
}
