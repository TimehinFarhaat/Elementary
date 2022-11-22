using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using StudentAppFile.Model;


namespace StudentAppFile.Repositories
{
    class StudentRepository
    {
        List<Student> students=new List<Student>();

        string file = "C:\\Users\\staa99\\source\\repos\\StudentAppFile\\StudentAppFile\\Files\\studentFile.txt";
        





       public StudentRepository()
       {
           ReadStudentFromFile();
       }




       private void ReadStudentFromFile()
       {
           try
           {
               if (File.Exists(file))
               {
                   var Allstudents = File.ReadAllLines(file);
                   foreach (var item in Allstudents)
                   {
                       students.Add(Student.ToStudent(item));
                   }
               }
               else
               {
                   string path = "C:\\Users\\staa99\\source\\repos\\StudentAppFile\\StudentAppFile\\Files";
                    Directory.CreateDirectory(path);
                   
                   string FileName = "studentFile.txt";
                   string fullPath = Path.Combine(path, FileName);
                   File.Create(fullPath);
               }
           }
           catch (Exception e)
           {
               Console.WriteLine(e.Message);
               
           }
       }

      






        public Student RegisterStudent()
       {
           Console.Write("Enter Id: ");
           int id =int.Parse(Console.ReadLine());
            Console.Write("Enter  First Name: ");
           string firstname = Console.ReadLine();
           Console.Write("Enter  Last Name: ");
           string lastname = Console.ReadLine();
           Console.Write("Enter  age: ");
           int age =int.Parse(Console.ReadLine());
            Console.Write("Enter  Address: ");
           string address = Console.ReadLine();
           Console.Write("Enter  phoneNumber: ");
           string phoneNum = Console.ReadLine();
            Console.Write("Enter  Email: ");
           string email = Console.ReadLine();
          

           Console.WriteLine(" You have been registered successfully");

            var student=new Student(id,firstname,lastname,age,address,phoneNum,email);

            AddStudentFile(student);
            students.Add(student);
           return new Student(id,firstname,lastname,age,address,phoneNum,email);

       }



       private void AddStudentFile (Student student)
       {
           try
           {
               using (StreamWriter write = new StreamWriter(file, true))
               {
                   write.WriteLine(student.ToString());
               }
           }
           catch (Exception e)
           {
               Console.WriteLine(e.Message);
               
           }
       }






        public void GetAll()
       {
           if (students.Count == 0)
           {
               Console.WriteLine("THERE IS NO STUDENT AVAILABLE ");
           }
           else
           {
               foreach (var student in students)
               {
                   PrintStudent(student);
               }
           }
       }




       private void PrintStudent(Student student)
       {
           Console.WriteLine(student.ToString());
       }



       public void GetStudent ()
       {
           if (students.Count == 0)
           {
               Console.WriteLine("THERE IS NO STUDENT AVAILABLE ");
           }
           else
           {
               foreach (var student in students)
               {
                   Console.Write("Enter Id: ");
                   int id =int.Parse(Console.ReadLine());
                   if (id == student.Id)
                   {
                       Console.WriteLine($"{student.FirstName}     {student.LastName}");
                       break;
                   }
                }
            }
       }




        



       public void UpdateStudent()
       {
           Console.Write("Enter the id of student to update: ");
           var id = int.Parse(Console.ReadLine());
           var student = GetStudentById(id);
           if (student != null)
           {
               Console.Write("Enter student first name:");
               string fistname = Console.ReadLine();
               Console.Write("Enter student last name:");
               string lastname = Console.ReadLine();
               Console.Write("Enter student age:");
               int age =int.Parse(Console.ReadLine());


               student.FirstName = fistname;
               student.LastName = lastname;
               student.Age = age;

               RefreshFile();
               Console.WriteLine($"Student with id:{id} updated successfully");
           }
           else
           {
               Console.WriteLine($"Student with id:{id} does not exists");
           }
       }




       public void DeleteStudent()
       {

           Console.Write("Enter the id of student to update: ");
           var id = int.Parse(Console.ReadLine());
           var student = GetStudentById(id);
           if (student != null)
           {
               students.Remove(student);
               RefreshFile();
               Console.WriteLine($"Student with id:{id} deleted successfully");
           }
           else
           {
               Console.WriteLine($"Student with id:{id} not found");
           }
        }




       public Student GetStudentById (int id)
       {
           foreach (var student in students)
           {
               if (student.Id == id)
               {
                   return student;
                   
               }
           }
           return null;
       }





        private void RefreshFile()
       {
           try
           {
               using (StreamWriter write = new StreamWriter(file, false))
               {
                   foreach (var student in students)
                   {
                       write.WriteLine(student.ToString());
                   }
               }
           }
           catch (Exception e)
           {
               Console.WriteLine(e.Message);
           }
       }


     
    }
}
