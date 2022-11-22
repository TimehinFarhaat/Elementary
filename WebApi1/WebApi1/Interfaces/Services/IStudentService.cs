using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi1.Dtos;
using WebApi1.Entity;


namespace WebApi1.Interfaces.Services
{
    public interface  IStudentService
    {
        public BaseResponse          AddStudent (CreateStudentRequest request);
        public StudentResponseModel  GetStudentById (int  id);
        public StudentResponseModel GetStudentByMatricNo (string matricNo);
        public BaseResponse          UpdateStudent (UpdateStudentRequest   request,string matricNo);
        public BaseResponse          DeleteStudent (string matricNo);
        public StudentsResponseModel GetStudents ();
    }
}
