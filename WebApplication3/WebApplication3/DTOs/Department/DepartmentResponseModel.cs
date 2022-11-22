using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.DTOs.Student;


namespace WebApplication3.DTOs.Department
{
    public class DepartmentResponseModel:BaseResponse
    {
        public DepartmentDto Data { get; set; }
    }
}
