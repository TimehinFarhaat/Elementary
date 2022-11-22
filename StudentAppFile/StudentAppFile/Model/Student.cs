using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAppFile.Model
{
    class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Student (int id, string firstName, string lastName, int age, string address, string phoneNumber, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Id}\t{FirstName}\t{LastName}\t{Age}\t{Address}\t{PhoneNumber}\t{Email}";
        }


        public static Student ToStudent(string student)
        {
            var studentStr = student.Split("\t");
            int id = int.Parse(studentStr[0]);
            string firstName = studentStr[1];
            string lastName = studentStr[2];
            string phoneNumber = studentStr[5];
            string address = studentStr[4];
            string email = studentStr[6];
            int age = int.Parse(studentStr[3]);
           Student st = new Student(id, firstName, lastName, age, address, phoneNumber, email);
           return st;
        }
    }
}
