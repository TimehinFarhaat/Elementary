using System;
using System.Collections.Generic;
using System.Text;

namespace EntiityRelationship
{
    class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public  int DepartmentId{ get; set; }
        public Department Department { get; set; }
        public int  StateId { get; set; }
        public State State { get; set; }
        public virtual List<StudentCourse> StudentCourses { get; set; }

    }
}
