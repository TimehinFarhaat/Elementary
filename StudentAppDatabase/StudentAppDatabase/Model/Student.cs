using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAppDatabase.Model
{
    class Student:Person
    {

        public string MatricNo { get; set; }
        public int LevelId { get; set; }


        public Student (int id, string firstname, string lastname, int age, string address, string phoneNum, string email,string password,string hashSalt,int departMentId,
                        string matricNo,int levelId)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Address = address;
            PhoneNum = phoneNum;
            Email = email;
            Password = password;
            HashSalt = hashSalt;
            DepartmentId = departMentId;
            MatricNo = matricNo;
            LevelId = levelId;
        }


       
    }
}
