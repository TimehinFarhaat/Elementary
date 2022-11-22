using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAppDatabase.Model
{
    class Level
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfStudent { get; set; }


        public Level(int id, string name, int numberOfStudent)
        {
            Id = id;
            Name = name;
            NumberOfStudent = numberOfStudent;
        }
       
    }
}
