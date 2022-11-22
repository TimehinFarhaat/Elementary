using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication3.DTOs.Student
{
    public class StudentDtO
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string HoD { get; set; }
        public string DepartmentAddress { get; set; }
    }
}