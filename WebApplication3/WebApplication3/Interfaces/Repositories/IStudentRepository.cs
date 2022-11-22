using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.DTOs.Student;
using WebApplication3.Entities;


namespace WebApplication3.Interfaces.Repositories
{
    public interface IStudentRepository
    {
         StudentDtO GeTeacher(int id);
         Student GetStudent(int id);
         bool AddTeacher(Student teacher);
         bool DeleteTeacher(int id);
         bool UpdateTeacher(Student student);
         bool EmailExist(string email);
         bool NameExist(string name);
         IList<StudentDtO> Teachers();


    }
}
