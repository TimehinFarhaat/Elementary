using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.DTOs.Student;


namespace WebApplication3.DTOs.Department
{
    public class DepartmentDto
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string Address { get; set; } 
        public string DepartmentName { get; set; }
        public string HoD { get; set; }
        public ICollection<StudentDtO> Student { get; set; }=new List<StudentDtO>();
    }
}
