using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TwoEntites.Entities;
using TwoEntites.Interfaces.Services;


namespace TwoEntites.Controllers
{
    public class WorkerController:Controller
    {
        private readonly IWorkerService _workerService;
        private readonly IDepartmentService _departmentService;
        public WorkerController(IWorkerService workerService,IDepartmentService departmentService)
        {
            _workerService = workerService;
            _departmentService = departmentService;
        }



        public IActionResult Index ()
        {
            var g = _workerService.GetWorkers();
            return View(g);
        }



        public IActionResult AddWorker ()
        {
            var departments = _departmentService.GetDepartment();
            ViewData["Departments"] = new SelectList(departments, "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult AddWorker (Worker worker)
        {
            var f = _workerService.RegisterWorker(worker);
            return RedirectToAction("Index");
        }





        public IActionResult EditWorker(int id)
        {
            var depart = _departmentService.GetDepartment();
            var s = _workerService.GetWorker(id);

            if (s==null )
            {
                return NotFound($"Worker with id {id} does not exist");
            }
            else
            {
                ViewData["Department"] = new SelectList(depart, "Id", "Name");
                return View(s);
            }
        }
        [HttpPost]
        public IActionResult EditWorker (int id,Worker worker)
        {
            var f = _workerService.UpdateWorker(id, worker);
            
            return RedirectToAction("Index");
        }




        public IActionResult DepartmentWorker (int id)
        {
            var departments = _workerService.DepartWorkers(id);
            return View(departments);
        }



        public IActionResult GetWorker (int id)
        {
            var departments = _workerService.GetWorker(id);
            return View(departments);
        }


        public IActionResult Delete (int id)
        {
            var departments = _workerService.GetWorker(id);
            if (departments==null)
            {
                return NotFound($"Worker with id {id} does not exist");
            }
            return View(departments);
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed (int id)
        {
            var f = _workerService.DeleteWorker(id);
            return RedirectToAction("Index");
        }


    }
}
