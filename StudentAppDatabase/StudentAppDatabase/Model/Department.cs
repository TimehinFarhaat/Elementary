using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAppDatabase.Model
{
    class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public Department (int id, string name, string code, string description)
        {
            Id = id;
            Name = name;
            Code = code;
            Description = description;
        }


      
    }
}
