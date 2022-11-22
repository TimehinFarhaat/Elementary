using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentAppFile.Models;


namespace StudentAppFile.Repositories
{
   public class StudentRepository
   {
        string file = "C:\\Users\\staa99\\source\\ repos\\example\\Example\\File\\studentFiles.txt";
        List<Student> students = new List<Student>();


        public StudentRepository()
        {
            ReadStudentsFromFile();
        }


        private void ReadStudentsFromFile()
        {
           
           
            if (File.Exists(file))
            {
                var allStudents = File.ReadAllLines(file);
                foreach (var s in allStudents)
                {
                    students.Add(Student.ToStudent(s));
                }
            }
            else
            {
                File.Create(file);
            }
        }


        public Student Register()
        {
            Console.Write("Enter student name: ");
            string firstname = Console.ReadLine();
            Console.Write("Enter student Last name: ");
            string lastname = Console.ReadLine();
            Console.Write("Enter student age: ");
            int  age = int.Parse(Console.ReadLine());
            Console.Write("Enter student id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter student address: ");
            string address = Console.ReadLine();
            Console.Write("Enter student Phone Number: ");
            string phoneNum = Console.ReadLine();
            Console.Write("Enter student Email: ");
            string email = Console.ReadLine();

            var student=new Student(id, firstname, lastname, age, address, phoneNum, email);
            students.Add(student);
            RefreshFile();
            return student;
        }

        private void AddStudentFile(Student student)
        {
            using (StreamWriter write = new StreamWriter(file,true))
            {
                write.WriteLine(student.ToString());
            }
        }


        private void RefreshFile()
        {
            using (StreamWriter fs = new StreamWriter(file))
            {
            }
        }


   }
}
