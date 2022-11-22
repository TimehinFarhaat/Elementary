using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using WebApi1.Dtos;
using WebApi1.Entity;
using WebApi1.Interfaces.Repository;
using WebApi1.Interfaces.Services;


namespace WebApi1.Implementation.Services
{
    public class StudentService:IStudentService
    {
        private readonly IStudentRepository _studentRepository;


        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }





        public BaseResponse AddStudent(CreateStudentRequest request)
        {
            var student = new Student()
            {
                Address = request.Address,
                FirstName = request.FirstName,
                LastName = request.LastName,
                MatricNo = Guid.NewGuid().ToString().Substring(0, 5)
            };

          var t=  _studentRepository.Add(student);
            return  new BaseResponse()
            {
                Message ="Successful" +
                         "Your matric number is "+ t.MatricNo,
                Status = true
            };
        }





        public StudentResponseModel GetStudentById(int id)
        {
            var student = _studentRepository.Get(y => y.Id ==id);
            if (student == null)
            {
                return new StudentResponseModel()
                {
                    Message = $"Student with id {id} does not exist",
                    Status = false
                };
            }
            return new StudentResponseModel()
            {
                Status = true,
                Message = "Successful",
                Data = new StudentDto()
                {
                    Address = student.Address,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    MatricNo = student.MatricNo
                }
            };
        }



        public StudentResponseModel GetStudentByMatricNo(string matricNo)
        {
            var student = _studentRepository.Get(y => y.MatricNo == matricNo);
            if (student == null)
            {
                return new StudentResponseModel()
                {
                    Message = $"Student with matric number:{matricNo} does not exist",
                    Status = false
                };
            }
            return new StudentResponseModel()
            {
                Status = true,
                Message = "Successful",
                Data = new StudentDto()
                {
                    Address = student.Address,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    MatricNo = student.MatricNo
                }
            };

        }




        public BaseResponse UpdateStudent(UpdateStudentRequest request,string matricNo)
        {
            var student = _studentRepository.Get(u => u.MatricNo==matricNo);
            if (student == null)
            {
                return new BaseResponse()
                {
                    Message = $"Student with Matric Number {matricNo} does not exist",
                    Status = false
                };
            }
            student.Address = request.Address;
             student.FirstName = request.FirstName;
             student.LastName = request.LastName;
            

            _studentRepository.Update(student);
            return new BaseResponse()
            {
                Message = "Successful",
                Status = true
            };
        }


        
        public BaseResponse DeleteStudent(string matricNo)
        {
            var  student = _studentRepository.Get(y => y.MatricNo == matricNo);
            if (student == null)
            {
                return new StudentResponseModel()
                {
                    Message = $"Student with Matric Number:{matricNo} does not exist",
                    Status = false
                };
            }
            _studentRepository.Delete(student);
            return new BaseResponse()
            {
                Message = "Successful",
                Status = true
            };
        }





        public StudentsResponseModel GetStudents()
        {
            var students = _studentRepository.GetAll();
            if (students.Count == 0)
            {
                return new StudentsResponseModel()
                {
                    Message = $"No available student",
                    Status = false
                };
            }
            return new StudentsResponseModel()
            {
                Status = true,
                Message = "Successful",
                Data = students.Select(student=>new StudentDto
                {
                    Address = student.Address,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    MatricNo = student.MatricNo
                }).ToList()
                
            };
        }
    }
}
