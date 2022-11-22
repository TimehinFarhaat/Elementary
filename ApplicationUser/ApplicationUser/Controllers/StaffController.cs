using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationUser.DTOs;
using ApplicationUser.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace ApplicationUser.Controllers
{
    public class StaffController:Controller
    {
        private readonly IStaffService _staffService;
        private readonly IRoleService  _roleService;


        public StaffController (IStaffService staffService, IRoleService roleService)
        {
            _staffService = staffService;
            _roleService = roleService;
        }

        public IActionResult RegisterStaff ()
        {
            var roles = _roleService.GetRoles();
            ViewData["Roles"] = new SelectList(roles, "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult RegisterStaff (StaffRequestModel staffRequest)
        {
            var roles = _staffService.AddStaff(staffRequest);
            return RedirectToAction("Index", "Home");
        }
    }
}
