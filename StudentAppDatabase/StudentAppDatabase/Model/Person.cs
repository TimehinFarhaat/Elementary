using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAppDatabase.Model
{
  public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string PhoneNum { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public string Password { get; set; }
        public int DepartmentId { get; set; }
        public string HashSalt { get; set; }


    }
}
