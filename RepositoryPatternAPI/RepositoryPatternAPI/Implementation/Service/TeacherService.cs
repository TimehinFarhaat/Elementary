using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepositoryPatternAPI.DTOs;
using RepositoryPatternAPI.Entities;
using RepositoryPatternAPI.Interfaces.Repository;
using RepositoryPatternAPI.Interfaces.Services;


namespace RepositoryPatternAPI.Implementation.Service
{
    public class TeacherService:ITeacherSrervice
    {
        private readonly ITeacherRepository _teacherRepository;


        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }


        public BaseResponse DeleteTeacher(int id)
        {
            var teacher = _teacherRepository.Get(x => x.Id == id);
            if (teacher != null)
            {
                _teacherRepository.Delete(teacher);
                return new BaseResponse()
                {
                    Message = "Deleted successfully",
                    Status = true,
                };
            }
            _teacherRepository.Delete(teacher);
            return new BaseResponse()
            {
                Message = "Not found",
                Status = false,
            };
        }



        public BaseResponse RegisterTeacher (CreateTeacherRequest request)
        {
            var teacherExist = _teacherRepository.Exist(x => x.EmailAddress == request.EmailAddress);
            if (teacherExist )
            {
                return new BaseResponse()
                {
                    Status =false,
                    Message = "Already exist"
                };
            }
            var teacher=new Teacher()
            {
                EmailAddress = request.EmailAddress,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Age = request .Age,
                StaffId = $"AD{Guid.NewGuid().ToString().Substring(0,3)}"
            };
           _teacherRepository.Add(teacher);
            return new BaseResponse()
            {
                Status = true,
                Message = $"Registered successfully /n" +
                          $"Your Id is {teacher.StaffId}"
            };
        }



        public BaseResponse UpdateTeacher (CreateTeacherRequest request)
        {
            var teacher = _teacherRepository.Get(y => y.EmailAddress == request.EmailAddress);
            if (teacher==null)
            {
                return new BaseResponse()
                {
                    Status = false,
                    Message = "Does not exist"
                };
            }
            teacher.EmailAddress = request.EmailAddress;
            teacher.FirstName = request.FirstName;
            teacher.LastName = request.LastName;
            teacher.Age = request.Age;
            teacher.StaffId = Guid.NewGuid().ToString().Substring(0, 4);

            _teacherRepository.Update(teacher);
            return new BaseResponse()
            {
                Status = true,
                Message = "Registered successfully"
            };
        }






        public TeacherResponseModel GetTeacher (int id)
        {
            var teacher = _teacherRepository.Get(x => x.Id == id);
            
            return new TeacherResponseModel()
            {
                Data = new TeacherDto()
                {
                    Age = teacher.Age,
                    EmailAddress = teacher.EmailAddress,
                    FirstName = teacher.FirstName,
                    LastName = teacher.LastName,
                    StaffId = teacher .StaffId,
                    Id = teacher.Id
                },
                Message = $"Teacher with Name{teacher.FirstName} {teacher.LastName} successfully retrieved",
                Status = true
            };

        }



        public TeachersResponseModel GetTeachers ()
        {
            var teacher = _teacherRepository.Get();
            return new TeachersResponseModel()
            {
                Data = teacher.Select(teach => new TeacherDto
                {
                    Age = teach.Age,
                    EmailAddress = teach.EmailAddress,
                    FirstName = teach.FirstName,
                    LastName = teach.LastName,
                    StaffId = teach.StaffId,
                    Id = teach.Id
                }).ToList(),
                Message = $"Teachers successfully retrieved",
                Status = true
            };
        }
    }
}
