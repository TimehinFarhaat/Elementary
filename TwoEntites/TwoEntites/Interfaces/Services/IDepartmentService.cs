using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwoEntites.Entities;


namespace TwoEntites.Interfaces.Services
{
    public interface IDepartmentService
    {
        bool     RegisterDepartment (Department teacher);
        string   DeleteDepartment (int  id);
        Department  GetDepartment (int  id);
        IList<Department> GetDepartment ();
        bool  UpdateDepartment (int id, Department departments);
    }
}
