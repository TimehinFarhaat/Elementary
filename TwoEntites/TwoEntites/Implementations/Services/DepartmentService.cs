using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwoEntites.Entities;
using TwoEntites.Implementations.Repository;
using TwoEntites.Interfaces.Repository;
using TwoEntites.Interfaces.Services;


namespace TwoEntites.Implementations.Services
{
    public class DepartmentService:IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;


        public DepartmentService (IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }


        public bool RegisterDepartment (Department teacher)
        {
            var v = _departmentRepository.NameExist(teacher.Name);
            if (v)
            {
                throw new Exception($"Department with Name {teacher.Name} already exist");
            }
            var department=new Department()
            {
                Name = teacher.Name,
                Code = teacher.Code,
            };

            _departmentRepository.AddDepartment(department);
            return true;
        }



        public string DeleteDepartment (int id)
        {
            var r = _departmentRepository.GetDepartments(id);

            if (r == null)
            {
                throw new Exception($"Department with {id} does not exist");
            }
            else
            {
                _departmentRepository.DeleteDepartment(id);
                return $"Teacher with {id} is deleted successfully";
            }
        }


        public Department GetDepartment (int id)
        {
            return _departmentRepository.GetDepartments(id);
        }



        public IList<Department> GetDepartment ()
        {
            return _departmentRepository.Departments();
        }


        public bool UpdateDepartment (int id, Department departments)
        {
            var v = _departmentRepository.NameExist(departments.Name);
            if (v)
            {
                throw new Exception($"Department with Name {departments.Name} already exist");
            }
            var s = _departmentRepository.GetDepartments(id);
            if (s == null)
            {
                throw new Exception($"Department with id {id} does not exist");
            }
            else
            {                                                                                                                         
                s.Name = departments.Name;
                s.Code = departments.Code;

                s.Workers = departments.Workers;
                _departmentRepository.UpdateDepartment(id);
                return true;
            }
        }
    }
}
