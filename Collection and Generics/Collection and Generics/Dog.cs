using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_and_Generics
{
    class Dog:Living 
    {
        public string Name { get; set; }

        public Dog(string name)
        {
            Name = name;

        }
        public string GetName ()
        {
            return Name;
        }
    }
}
