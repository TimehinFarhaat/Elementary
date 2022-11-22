using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.DTOs.Student
{
    public class StudentResponseModel:BaseResponse
    {
        public StudentDtO Data { get; set; }
        
    }
}
