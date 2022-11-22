using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.DTOs.Student
{
    public  abstract class BaseResponse
    { 
        public string Message { get; set; }
        public bool Status { get; set; }
    }
}
