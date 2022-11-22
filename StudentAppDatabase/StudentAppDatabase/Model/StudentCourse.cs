using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAppDatabase.Model
{
    class StudentCourse
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public StudentCourse (int id, int studentId, int courseId)
        {
            Id = id;
            StudentId = studentId;
            CourseId = courseId;
        }

    }
}
