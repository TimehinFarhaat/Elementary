using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternAPI.DTOs
{
    public class TeacherDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string EmailAddress { get; set; }
        public string StaffId { get; set; }
    }


    public class CreateTeacherRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string EmailAddress { get; set; }
   }
    public class UpdateTeacherRequest
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string EmailAddress { get; set; }
    }
    public class TeacherResponseModel:BaseResponse
    {
       public TeacherDto Data { get; set; }
    }

    public class TeachersResponseModel : BaseResponse
    {
        public IList<TeacherDto> Data { get; set; }
    }
}
