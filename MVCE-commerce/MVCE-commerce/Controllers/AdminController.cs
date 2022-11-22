using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCE_commerce.DTO;
using MVCE_commerce.Entities;
using MVCE_commerce.Interface.Service;


namespace MVCE_commerce.Controllers
{
 
    public class AdminController:Controller
    {
        private readonly IAdminService _adminService;


        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }



        public IActionResult Index ()
        {
            var t = _adminService.GetAllAdmin();
            return View(t.Data);
        }







        public IActionResult AddAdmin ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAdmin (AdminRequestModel admin)
        {
            _adminService.CreateAdmin(admin);
            return RedirectToAction("AdminChoice");
        }







        public IActionResult AdminPage ()
        {
            var UserId = HttpContext.Session.GetInt32("Id");
            if (UserId != null)
            {
                var admin = _adminService.GetAdmin(UserId.Value);
                if (admin == null)
                {
                    return NotFound($"Customer with  id {UserId} does not exist");
                }
                return View(admin.Data);

            }
            else
            {
                return RedirectToAction("Login");
            }

        }





        
        public IActionResult Login ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login (AdminRequest admin)
        {
          var t=  _adminService.LoginAdmin(admin);
          ViewBag.Message = t.Message;
            if (t.Status==true)
            {
              HttpContext.Session.SetString("Email",admin.EmailAddress);
              HttpContext.Session.SetString("Name",t.Data.FirstName);
              HttpContext.Session.SetInt32("Id",t.Data.AdminId);
              return RedirectToAction("AdminPage");
            }
            return View(); 
        }



        public IActionResult AdminChoice ()
        {

            return View();
        }





        public IActionResult LogOut ()
        {
            HttpContext.Session.Clear();
            return View("Success");
        }








        public IActionResult UpdateAdmin ()
        {
            var id = HttpContext. Session.GetInt32("Id");
            var admin = _adminService.GetAdmin(id.Value);
            if (admin == null)
            {
                return NotFound($"Admin with  id {id} does not exist");
            }
            else
            {
                return View(admin.Data);
            }
        }
        [HttpPost]
        public IActionResult UpdateAdmin (AdminRequestModel admin)
        {
             var id = HttpContext.Session.GetInt32("Id");
            _adminService.UpdateAdmin(id.Value,admin);
            
            return RedirectToAction("Details", new { id = id });
        }







        public IActionResult Details ()
        {
            var id = HttpContext.Session.GetInt32("Id");
            var admin = _adminService.GetAdmin(id.Value);
            if (admin == null)
            {
                return NotFound($"Admin with  id {id} does not exist");
            }
            else
            {
                return View(admin.Data);
            }
        }








        public IActionResult DeleteAdmin ()
        {
            var id = HttpContext.Session.GetInt32("Id");
            var admin = _adminService.GetAdmin(id.Value);
            if (admin == null)
            {
                return View(admin.Message);
            }
            else
            {
                return View(admin.Data);
            }
        }
        [HttpPost, ActionName("DeleteAdmin")]
        public IActionResult DeleteConfirmed ()
        {
            var id = HttpContext.Session.GetInt32("Id");
            _adminService.DeleteAdmin(id.Value);
            return RedirectToAction("Index");
        }
    }
}
