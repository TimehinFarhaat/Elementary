using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.DTOs.Department;
using WebApplication3.DTOs.Student;
using WebApplication3.Entities;
using WebApplication3.Interfaces.Repositories;
using WebApplication3.Interfaces.Services;


namespace WebApplication3.Implementations.Services
{
    public class DepartmentSErvice:IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;


        public DepartmentSErvice (IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }


        public bool RegisterDepartment(Department department)
        {
            

            var nameExist = _departmentRepository.NameExist(department.Name);
            if (nameExist)
            {
                throw new Exception($"Teacher with {department.Name} already exist");
            }

            var teach=new Department()
            {
                Name =department.Name,
                Address = department.Address,
                HOD = department.HOD,

            };
            _departmentRepository.AddDepartment(teach);
            return true;
        }



        public string DeleteDepartment(int id)
        {
            var teacher = _departmentRepository.GetDepartment(id);
            if (teacher == null)
            {
                throw new Exception($"Teacher with {id} does not exist");
            }
            else
            {
                _departmentRepository.DeleteDepartment(id);
                return $"Teacher with {id} is deleted successfully";
            }
        }



        public DepartmentResponseModel GetDepartment(int id)
        {
            var depart = _departmentRepository.GetDepartment(id);
            if (depart == null)
            {

                return new DepartmentResponseModel()
                {
                    Message = $"{depart.DepartmentName}  does not exist",
                    Status = false,
                };
            }
            return new DepartmentResponseModel()
            {
                Message = $"{depart.DepartmentName} successfully get",
                Data = depart,
                Status = true,
            };
        }


        public DepartmentsResponseModel GetDepartment()
        {
            var s = _departmentRepository.Departments();
            return new DepartmentsResponseModel()
            {
                Data = s,
            };
        }


        public bool UpdateDepartment(int id, Department department)
        {
            var s = _departmentRepository.GetDepart(id);
            if (s == null)
            {
                throw new Exception($"Student with id {id} does not exist");
            }
            else
            {
                s.Name = department.Name;
                s.Address = department.Address;
                s.HOD = department.HOD;

                _departmentRepository.UpdateDepartment(s);
                return true;
            }
        }
    }
}
