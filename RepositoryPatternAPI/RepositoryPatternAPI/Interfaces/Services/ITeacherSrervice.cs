using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepositoryPatternAPI.DTOs;


namespace RepositoryPatternAPI.Interfaces.Services
{
    public interface ITeacherSrervice
    {
        public BaseResponse RegisterTeacher(CreateTeacherRequest request);
        public TeacherResponseModel GetTeacher(int id);
        public BaseResponse UpdateTeacher(CreateTeacherRequest request);
        public BaseResponse DeleteTeacher(int id);
        public TeachersResponseModel GetTeachers();
    }
}
