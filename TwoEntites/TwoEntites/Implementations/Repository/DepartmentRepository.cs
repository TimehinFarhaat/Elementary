using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwoEntites.Context;
using TwoEntites.Entities;
using TwoEntites.Interfaces.Repository;


namespace TwoEntites.Implementations.Repository
{
    public class DepartmentRepository:IDepartmentRepository
    {
        private readonly ApplicationContext _context;


        public DepartmentRepository (ApplicationContext context)
        {
            _context = context;
        }

        public Department GetDepartments (int id)
        {
            var f = _context.Departments.Find(id);
            return f;
        }




        public bool AddDepartment (Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
            return true;
        }


        Department IDepartmentRepository.GetDepartments(int id)
        {
            return _context.Departments.Find(id);
        }


        public bool DeleteDepartment (int id)
        {
            var g = _context.Departments.Find(id);
            _context.Departments.Remove(g);
            _context.SaveChanges();
            return true;
        }


        public bool UpdateDepartment (int id)
        {
            var g = _context.Departments.Find(id);
            _context.Departments.Update(g);
            _context.SaveChanges();
            return true;
        }


        public bool NameExist (string name)
        {
            return _context.Departments.Any(l => l.Name == name);
        }




        public IList<Department> Departments ()
        {
            return _context.Departments.ToList();
        }


    }
}
