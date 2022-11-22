using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAppDatabase.Model
{
    class Course
    {
        public string Name { get; set; }
        public int  Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public Course (int id, string name, string code,string description)
        {
            Id = id;
            Name = name;
            Code = code;
            Description = description;
        }

    }
}
