using System;
using System.Collections.Generic;
using System.Text;

namespace EntiityRelationship
{
    class Department
    {
        public string Name { get; set;}
        public int Id { get; set; }
       public  virtual List<Student> students { get; set; }
    }

}
