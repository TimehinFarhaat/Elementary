using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Context;
using WebApplication3.DTOs.Department;
using WebApplication3.DTOs.Student;
using WebApplication3.Entities;
using WebApplication3.Interfaces.Repositories;


namespace WebApplication3.Implementations.Repositories
{
    public class DepartmentRepository:IDepartmentRepository
    {
        private readonly ApplicationContext _context;


        public DepartmentRepository (ApplicationContext context)
        {
            _context = context;
        }



        public DepartmentDto GetDepartment(int id)
        {
            var d = _context.Departments.SingleOrDefault(i => i.Id == id);
            return new DepartmentDto()
            {
                DepartmentName = d.Name,
                DepartmentId = d.Id,
                HoD = d.HOD,
                Address = d.Address
            };
        }


        public Department GetDepart(int id)
        {
            var d = _context.Departments.Find(id);
            _context.Departments.Update(d);
            _context.SaveChanges();
            return d;
        }


        public bool AddDepartment(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
            return true;
        }



        public bool DeleteDepartment(int id)
        {
            var d = _context.Departments.Find(id);
            _context.Departments.Remove(d);
            _context.SaveChanges();
            return true;
        }



        public bool UpdateDepartment(Department department)
        {
            
            _context.Departments.Update(department);
            _context.SaveChanges();
            return true;
        }




        public bool NameExist (string name)
        {
            return _context.Departments.Any(r => r.Name == name);
        }


        

        public IList<DepartmentDto> Departments ()
        {
            return _context.Departments.Include(s => s.Students)
                           .Select(d => new DepartmentDto()
                           {
                               DepartmentName = d.Name,
                               DepartmentId = d.Id,
                               HoD = d.HOD,
                               Address = d.Address

                           })
                           .ToList();
        }


       
    }
}
