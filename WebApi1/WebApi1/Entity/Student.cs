using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi1.Entity
{
    public class Student:BaseEntity
    {
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public string  Address { get; set; }
        public string MatricNo { get; set; }
    }
}
