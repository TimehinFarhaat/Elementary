using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverLoading
{
    class Student
    {

        public string Name { get; set; }
        public  int Age { get; set; }
        public string  SurnName { get; set; }
        public  Gender Gender { get; set; }





        public Student (string name, string surName,int age,Gender gender)
        {
            Name = name;
            SurnName = surName;
            Age = age;
            Gender = gender;
        }


        /// <inheritdoc />
        public override string ToString()
        {
            return $"Name:{Name}  {SurnName} \nAge: {Age} \nGender:{Gender}\n";
        }































        //public Student()
        //{

        //}



        //public static Student operator +(Student s1, Student s2)
        //{
        //    Student s= new Student();
        //    s.Name = s1.Name + "" + s2.Name;
        //    s.Score = s1.Score +  s2.Score;
        //    return s;
        //}

        //public static bool operator <(Student s1, Student s2)
        //{
        //    return s1.Score < s2.Score;
        //}



        //public static bool operator > (Student s1, Student s2)
        //{
        //    return s1.Score < s2.Score;
        //}




        //public static bool operator !=(Student s1, Student s2)
        //{
        //    return s1.Score == s2.Score;
        //}
        


        //public static bool operator == (Student s1, Student s2)
        //{
        //    return s1.Score == s2.Score;
        //}

        //public override bool Equals (object obj)
        //{
        //    if (ReferenceEquals(this, obj))
        //    {
        //        return true;
        //    }

        //    if (ReferenceEquals(obj, null))
        //    {
        //        return false;
        //    }

        //    throw new NotImplementedException();
        //}
    }
}
