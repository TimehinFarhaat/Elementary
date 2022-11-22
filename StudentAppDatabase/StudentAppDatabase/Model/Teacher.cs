using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAppDatabase.Model
{
    class Teacher:Person
    {
        public int StaffId { get; set; }


        public Teacher(int    id,
                       string firstname,
                       string lastname,
                       int    age,
                       string address,
                       string phoneNum,
                       string email,
                       string password,
                       string hashSalt,
                       int    departMentId,
                       int    staffId)
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
            StaffId = staffId;
        }
    }
}
