using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwoEntites.Entities;


namespace TwoEntites.Interfaces.Repository
{
    public interface IDepartmentRepository
    {
        Department  GetDepartments (int  id);
        bool    AddDepartment (Department department);
        bool    DeleteDepartment (int  id);
        bool    UpdateDepartment (int   id);
        bool     NameExist (string   name);
        IList<Department> Departments ();
 
    }
}
