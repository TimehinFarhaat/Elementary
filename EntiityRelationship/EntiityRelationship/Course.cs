using System;
using System.Collections.Generic;
using System.Text;

namespace EntiityRelationship
{
    class Course
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<StudentCourse> StudentCourses { get; set; } 
    }
}
