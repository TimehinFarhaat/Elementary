using System;
using System.Collections.Generic;
using System.Text;

namespace EntiityRelationship
{
    class State
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
    }
}
