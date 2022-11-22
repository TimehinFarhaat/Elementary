using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.DTOs.Student;
using WebApplication3.Entities;
using WebApplication3.Interfaces.Repositories;
using WebApplication3.Interfaces.Services;


namespace WebApplication3.Implementations.Services
{
    public class StudentService:IStudentService
    {

        private readonly IStudentRepository _studentRepository;


        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }


        public bool RegisterTeacher(Student teacher)
        {
            var EmailExist = _studentRepository.EmailExist(teacher.Email);
            if (EmailExist)
            {
                throw new Exception($"Email {teacher.Email} already exist");
            }

            var nameExist = _studentRepository.NameExist(teacher.FirstName);
            if (nameExist)
            {
                throw new Exception($"Teacher with {teacher.FirstName} already exist");
            }

            if (teacher.Age < 18)
            {
                throw new Exception($"Student is underage");
            }
            var teach=new Student()
            {
                FirstName = teacher.FirstName,
                LastName = teacher.LastName,
                DepartmentId = teacher.DepartmentId,
                Age = teacher.Age,
                Email = teacher.Email,

            };
              _studentRepository.AddTeacher(teach);
              return true;
        }
          

        public string DeleteTeacher(int id)
        {
            var teacher = _studentRepository.GeTeacher(id);
            if (teacher==null)
            {
                throw new Exception($"Teacher with {id} does not exist");
            }
            else
            {
                _studentRepository.DeleteTeacher(id);
                return $"Teacher with {id} is deleted successfully";
            }
        }



        public StudentResponseModel GetTeacher(int id)
        {
            var student = _studentRepository.GeTeacher(id);
            if (student==null)
            {

                return new StudentResponseModel()
                {
                    Message = $"{student.Name}  does not exist",
                    Status = false,
                };
            }
            return new StudentResponseModel()
            {
                Message = $"{student.Name} successfully get",
                Data = student,
                Status = true,
            };
        }



        public StudentsResponseModel GetTeachers()
        {
            var y = _studentRepository.Teachers();
            return new StudentsResponseModel
            {
                Message = "",
                Status = true,
                Data = y

            };
        }


                                                                                                     
        public bool UpdateTeacher(int id,Student teacher)
        {
            var s = _studentRepository.GetStudent(id);
            if (s == null)
            {
                throw new Exception($"Student with id {id} does not exist");
            }
            else
            {
                s.FirstName = teacher.FirstName;
                s.LastName = teacher.LastName;
                s.Age = teacher.Age;
                s.DepartmentId = teacher.DepartmentId;
                s.Email = teacher.Email;

                _studentRepository.UpdateTeacher(s);
                return true;
            }

        }
    }
} 
