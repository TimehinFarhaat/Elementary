using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_and_Generics
{
    class Person:Living
    {
        public string  Name { get; set; }

        public Person(string name)
        {
            Name = name;

        }
        public string GetName()
        {
            return Name;
        }
    }
}
