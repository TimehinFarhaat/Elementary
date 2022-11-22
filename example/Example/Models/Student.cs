using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAppFile.Models
{
   public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string PhoneNum { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }


        public Student(int id,string firstname, string lastname, int age, string address, string phoneNum, string email)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Address = address;
            PhoneNum = phoneNum;
            Email= email;
        }


        public override string ToString()
        {
            return $"{Id}\t,{FirstName}\t{LastName}\t{Age}\t{Address}\t{PhoneNum}\t{Email}";
        }


        public static Student ToStudent(string student)
        {
            var studentStr = student.Split("\t");
            int id = int.Parse(studentStr[0]);
            string firstname = studentStr[1];
            var lastname = studentStr[2];
            var age = int.Parse(studentStr[3]);
            var address = studentStr[4];
            var phoneNum = studentStr[5];
            var email = studentStr[6];

            return new Student(id, firstname, lastname, age, address, phoneNum, email);
        }
    }
}
