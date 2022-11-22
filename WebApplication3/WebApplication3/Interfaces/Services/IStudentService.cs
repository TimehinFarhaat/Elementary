using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.DTOs.Student;
using WebApplication3.Entities;
using WebApplication3.Interfaces.Repositories;


namespace WebApplication3.Interfaces.Services
{
    public interface IStudentService
    {
        bool RegisterTeacher(Student teacher);
        string DeleteTeacher (int id);
        StudentResponseModel GetTeacher (int id);
        StudentsResponseModel GetTeachers();
        bool UpdateTeacher (int id,Student teacher);

    }
}
