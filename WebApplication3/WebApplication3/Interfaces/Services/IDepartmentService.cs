using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.DTOs.Department;
using WebApplication3.DTOs.Student;
using WebApplication3.Entities;


namespace WebApplication3.Interfaces.Services
{
    public interface IDepartmentService
    {
        bool      RegisterDepartment (Department department);
        string     DeleteDepartment (int       id);
        DepartmentResponseModel GetDepartment (int   id);
        DepartmentsResponseModel GetDepartment ();
        bool    UpdateDepartment (int id, Department department);
    }
}
