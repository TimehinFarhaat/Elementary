using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi1.Dtos
{
    public class StudentDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string MatricNo { get; set; }
    }


    public class CreateStudentRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }


    public class StudentResponseModel : BaseResponse
    {
        public StudentDto Data { get; set; }
    }



    public class StudentsResponseModel : BaseResponse
    {
        public IList<StudentDto>  Data { get; set; }
    }




    public class UpdateStudentRequest
    {
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}
