using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.DTOs.Student;


namespace WebApplication3.DTOs.Department
{
    public class DepartmentsResponseModel:BaseResponse
    {
        public IList<DepartmentDto> Data { get; set; }
    }
}
