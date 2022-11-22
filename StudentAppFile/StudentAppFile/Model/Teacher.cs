using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAppFile.Model
{
    class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Teacher ( string firstName, string lastName, int age, string address, string phoneNumber, string email)
        {
             GenerateId();
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        public Teacher (string firstName, string lastName, int age, string address, string phoneNumber, string email,int id)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
        }


        private int  GenerateId()
        {
            Random random=new Random();
            int rand = random.Next(1, 101);
            return rand;

        }


        public override string ToString ()
        {
            return $"{FirstName}\t{LastName}\t{Age}\t{Address}\t{PhoneNumber}\t{Email}\t{Id}";
        }


        public static Teacher ToTeacher (string teacher)
        {
            var TeacherStr = teacher.Split("\t");
            
            string firstName = TeacherStr[0];
            string lastName = TeacherStr[1];
            string phoneNumber = TeacherStr[4];
            string address = TeacherStr[3];
            string email = TeacherStr[5];
            int age = int.Parse(TeacherStr[2]);
            int id = int.Parse(TeacherStr[6]);
            Teacher teach = new Teacher(firstName, lastName, age, address, phoneNumber, email,id);
            return teach;
        }
    }
}
//