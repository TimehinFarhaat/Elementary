using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.DTOs.Student
{
    public class StudentsResponseModel:BaseResponse
    {
        public IList<StudentDtO> Data { get; set; }
    }
}
