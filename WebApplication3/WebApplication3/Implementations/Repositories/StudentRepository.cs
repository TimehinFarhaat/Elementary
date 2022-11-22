using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Context;
using WebApplication3.DTOs.Department;
using WebApplication3.DTOs.Student;
using WebApplication3.Entities;
using WebApplication3.Interfaces.Repositories;
using WebApplication3.Interfaces.Services;


namespace WebApplication3.Implementations.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationContext _context;


        public StudentRepository(ApplicationContext context)
        {
            _context = context;
        }

        public StudentDtO GeTeacher(int id)
        {
            var d = _context.Students.Include(o=>o.Department).SingleOrDefault(o=>o.Id==id);
            return new StudentDtO()
            {
                StudentId = d.Id,
                Name = d.FirstName +" "+d.LastName,
                Email = d.Email,
                Age = d.Age,
                DepartmentId=d.DepartmentId,
                DepartmentAddress = d.Department.Address,
                DepartmentName = d.Department.Name,
            }; 
        }



        public Student GetStudent(int id)
        {
            var d = _context.Students.Find(id);
            _context.Students.Update(d);
            _context.SaveChanges();
            return d;

        }


        public bool AddTeacher(Student teacher)
        {
            _context.Students.Add(teacher);
            _context.SaveChanges();
            return true;
        }


        public bool DeleteTeacher(int id)
        {
            var d = _context.Students.Find(id);
            _context.Students.Remove(d);
            _context.SaveChanges();
            return true;
        }


        public bool UpdateTeacher(Student student)
        {
           
            _context.Students.Update(student);
            _context.SaveChanges();
            return true;
        }



        public bool EmailExist(string email)
        {
            return _context.Students.Any(r => r.Email == email);
        }


        public bool NameExist(string name)
        {
            return _context.Students.Any(r => r.FirstName == name);
        }



        public IList<StudentDtO> Teachers()
        {
            return _context.Students.Include(s => s.Department)
                           .Select(d => new StudentDtO()
                            {
                                Id = d.Id,
                                Name = d.LastName + "  " + d.LastName,
                                Email = d.Email,
                                Age = d.Age,
                                DepartmentId = d.DepartmentId,
                                DepartmentAddress = d.Department.Address,
                                DepartmentName = d.Department.Name,
                            })
                           .ToList();
        }
    }
}





