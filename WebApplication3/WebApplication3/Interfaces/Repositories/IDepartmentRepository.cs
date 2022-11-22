using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.DTOs.Department;
using WebApplication3.Entities;


namespace WebApplication3.Interfaces.Repositories
{
    public interface IDepartmentRepository
    {
        DepartmentDto  GetDepartment (int   id);
        Department GetDepart (int id);
        bool       AddDepartment (Department department);
        bool      DeleteDepartment (int  id);
        bool      UpdateDepartment (Department department);
        bool    NameExist (string   name);
        IList<DepartmentDto> Departments ();
    }
}
